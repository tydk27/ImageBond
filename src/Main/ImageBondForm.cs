using ImageBond.Modal;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageBond.Main
{
    public partial class ImageBondForm : Form
    {
        private ImageEdit TopLeftImage = null;

        private ImageEdit TopRightImage = null;

        private ImageEdit BottomLeftImage = null;

        private ImageEdit BottomRightImage = null;

        public ImageBondForm()
        {
            InitializeComponent();

            string saveDirectory = Properties.Settings.Default.saveDirectory;
            if (string.IsNullOrEmpty(saveDirectory) || !System.IO.Directory.Exists(saveDirectory))
            {
                Properties.Settings.Default.saveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }

            FormClosing += new FormClosingEventHandler(OnCloseForm);
        }

        private void OnCloseForm(object sender, FormClosingEventArgs e)
        {
            if (TopLeftImage != null)
            {
                TopLeftImage.Dispose();
            }
            if (TopRightImage != null)
            {
                TopRightImage.Dispose();
            }
            if (BottomLeftImage != null)
            {
                BottomLeftImage.Dispose();
            }
            if (BottomRightImage != null)
            {
                BottomRightImage.Dispose();
            }
        }

        private void OnClickSaveButton(object sender, EventArgs args)
        {
            resultLabel.Text = null;

            int count = 0;

            if (HasImageInPictureBox(topLeftBox))
            {
                TopLeftImage = new ImageEdit((Bitmap)topLeftBox.Image);
                count++;
            }
            if (HasImageInPictureBox(topRightBox))
            {
                TopRightImage = new ImageEdit((Bitmap)topRightBox.Image);
                count++;
            }
            if (HasImageInPictureBox(bottomLeftBox))
            {
                BottomLeftImage = new ImageEdit((Bitmap)bottomLeftBox.Image);
                count++;
            }
            if (HasImageInPictureBox(bottomRightBox))
            {
                BottomRightImage = new ImageEdit((Bitmap)bottomRightBox.Image);
                count++;
            }

            if (count != 1 && count != 4)
            {
                ShowErrorMessae("指定可能な画像枚数は1枚もしくは4枚です");

                return;
            }

            string fileName = string.IsNullOrEmpty(saveFileNameBox.Text) ? "output.png" : saveFileNameBox.Text;

            string filePath = System.IO.Path.Combine(Properties.Settings.Default.saveDirectory, fileName);
            filePath += string.IsNullOrEmpty(System.IO.Path.GetExtension(filePath)) ? ".png" : null;

            if (System.IO.File.Exists(filePath))
            {
                DialogResult dialogResult = ShowYesNoMessae("既にファイルが存在します\n上書きしますか？");
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            int cropX = int.Parse(Properties.Settings.Default.cropX);
            int cropY = int.Parse(Properties.Settings.Default.cropY);
            int width = int.Parse(Properties.Settings.Default.width);
            int height = int.Parse(Properties.Settings.Default.height);
            
            ImageEdit topImage = null;
            ImageEdit bottomImage = null;
            ImageEdit chainedImage = null;

            Bitmap completed = null;

            try
            {
                if (count == 4)
                {
                    TopLeftImage.Crop(cropX, cropY);
                    TopRightImage.Crop(cropX, cropY);
                    BottomLeftImage.Crop(cropX, cropY);
                    BottomRightImage.Crop(cropX, cropY);

                    topImage = new ImageEdit(TopLeftImage.Chain(TopRightImage.GetImage(), true));
                    bottomImage = new ImageEdit(BottomLeftImage.Chain(BottomRightImage.GetImage(), true));

                    chainedImage = new ImageEdit(topImage.Chain(bottomImage.GetImage(), false));
                    chainedImage.Resize(width, height);
                    completed = chainedImage.GetImage();
                }
                else if (TopLeftImage != null)
                {
                    TopLeftImage.Crop(cropX, cropY);
                    TopLeftImage.Resize(width, height);
                    completed = TopLeftImage.GetImage();
                }
                else if (TopRightImage != null)
                {
                    TopRightImage.Crop(cropX, cropY);
                    TopRightImage.Resize(width, height);
                    completed = TopRightImage.GetImage();
                }
                else if (BottomLeftImage != null)
                {
                    BottomLeftImage.Crop(cropX, cropY);
                    BottomLeftImage.Resize(width, height);
                    completed = BottomLeftImage.GetImage();
                }
                else if (BottomRightImage != null)
                {
                    BottomRightImage.Crop(cropX, cropY);
                    BottomRightImage.Resize(width, height);
                    completed = BottomRightImage.GetImage();
                }

                ImageFormat format = GetImageFormat(System.IO.Path.GetExtension(filePath));
                completed.Save(filePath, format);

                resultLabel.Text = "【完了】 保存先：" + filePath;
            }
            catch (Exception e)
            {
                ShowErrorMessae(e.ToString());
            }
            finally
            {
                if (completed != null)
                {
                    completed.Dispose();
                }
                if (topImage != null)
                {
                    topImage.Dispose();
                }
                if (bottomImage != null)
                {
                    bottomImage.Dispose();
                }
            }
        }

        private bool HasImageInPictureBox(PictureBox pb)
        {
            return pb != null && pb.Image != null;
        }

        private ImageFormat GetImageFormat(string extension)
        {
            ImageFormat format = null;

            switch (extension)
            {
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
                case ".gif":
                    format = ImageFormat.Gif;
                    break;
                case ".jpg":
                    format = ImageFormat.Jpeg;
                    break;
                case ".png":
                    format = ImageFormat.Png;
                    break;
            }

            return format;
        }

        private DialogResult ShowYesNoMessae(string message)
        {
            return MessageBox.Show(message, "ImageBond", MessageBoxButtons.YesNo);
        }

        private DialogResult ShowErrorMessae(string message)
        {
            return MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDragEnterPictureBox(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void OnDragDropPictureBox(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (file.Length != 1)
            {
                ShowErrorMessae("画像ファイルは1つずつ選択してください");
                return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(
                file[0],
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read
            );
            Image img = Image.FromStream(fs);

            fs.Close();

            ((PictureBox)sender).Image = img;
        }

        private void OnClickShowVersionInfo(object sender, EventArgs e)
        {
            VersionInfoModal f = new VersionInfoModal()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(this);
            f.Dispose();
        }

        private void OnClickCustomizeResolution(object sender, EventArgs e)
        {
            CustomizeResolutionModal f = new CustomizeResolutionModal()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(this);
            f.Dispose();
        }

        private void OnClickCustomizeCrop(object sender, EventArgs e)
        {
            CustomizeCropModal f = new CustomizeCropModal()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(this);
            f.Dispose();
        }

        private void OnClickSetSaveDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "保存先フォルダを選択してください",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = Properties.Settings.Default.saveDirectory
            };

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.saveDirectory = fbd.SelectedPath;
            }
        }

        private void OnClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpeningContextMenuStripForResetImage(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ContextMenuStrip menu = (ContextMenuStrip)sender;

            Control source = menu.SourceControl;
            if (source == null)
            {
                return;
            }

            PictureBox pb = (PictureBox)source;
            if (pb.Image == null)
            {
                return;
            }

            pb.Image.Dispose();
            pb.Image = null;
        }
    }
}
