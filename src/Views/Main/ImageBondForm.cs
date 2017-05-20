using System;
using System.Drawing;
using System.Windows.Forms;
using ImageBond.Util;
using ImageBond.Views.Modal;

namespace ImageBond.Views.Main
{
    public partial class ImageBondForm : Form
    {
        /// <summary>
        /// MakeImage
        /// </summary>
        MakeImageClass mi = null;

        /// <summary>
        /// initialSaveDir
        /// </summary>
        string saveDirectory = null;

        /// <summary>
        /// init
        /// </summary>
        public ImageBondForm()
        {
            InitializeComponent();

            mi = new MakeImageClass();
            saveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        /// <summary>
        /// OnClickSaveButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickSaveButton(object sender, EventArgs e)
        {
            resultLabel.Text = null;

            Bitmap topRight = null;
            Bitmap topLeft = null;
            Bitmap bottomRight = null;
            Bitmap bottomLeft = null;

            int imageCnt = 0;

            topRight = CheckHasImage(topLeftBox, ref imageCnt);
            topLeft = CheckHasImage(topRightBox, ref imageCnt);
            bottomRight = CheckHasImage(bottomLeftBox, ref imageCnt);
            bottomLeft = CheckHasImage(bottomRightBox, ref imageCnt);

            if (imageCnt != 1 && imageCnt != 4)
            {
                resultLabel.Text = "【エラー】：指定可能な画像枚数は1枚もしくは4枚です";
                return;
            }

            string saveFileName = saveFileNameBox.Text;
            saveFileName = (string.IsNullOrEmpty(saveFileName)) ? "output.png" : saveFileName;

            string savePath = null;
            savePath = System.IO.Path.Combine(saveDirectory, saveFileName);
            savePath += (string.IsNullOrEmpty(System.IO.Path.GetExtension(savePath))) ? ".png" : null;

            if (System.IO.File.Exists(savePath))
            {
                DialogResult dialogResult = ShowYesNoMessae("既にファイルが存在します\n上書きしますか？");
                if (dialogResult == DialogResult.No) return;
            }

            int cropX = int.Parse(Properties.Settings.Default.cropX);
            int cropY = int.Parse(Properties.Settings.Default.cropY);
            int width = int.Parse(Properties.Settings.Default.width);
            int height = int.Parse(Properties.Settings.Default.height);
            
            Bitmap top = null;
            Bitmap bottom = null;
            Bitmap complete = null;

            try
            {
                topRight = mi.CropImage(topRight, cropX, cropY);
                topLeft = mi.CropImage(topLeft, cropX, cropY);
                top = mi.ChainImage(topRight, topLeft, true);

                bottomRight = mi.CropImage(bottomRight, cropX, cropY);
                bottomLeft = mi.CropImage(bottomLeft, cropX, cropY);
                bottom = mi.ChainImage(bottomRight, bottomLeft, true);

                if (imageCnt == 4)
                {
                    complete = mi.ChainImage(top, bottom, false);
                    complete = mi.ResizeImage(complete, width, height);
                }
                else
                {
                    if (topRight != null)
                    {
                        complete = mi.ResizeImage(topRight, width, height);
                    }
                    if (topLeft != null)
                    {
                        complete = mi.ResizeImage(topLeft, width, height);
                    }
                    if (bottomRight != null)
                    {
                        complete = mi.ResizeImage(bottomRight, width, height);
                    }
                    if (bottomLeft != null)
                    {
                        complete = mi.ResizeImage(bottomLeft, width, height);
                    }
                }

                System.Drawing.Imaging.ImageFormat format = mi.GetImageFormat(System.IO.Path.GetExtension(savePath));
                complete.Save(savePath, format);

                resultLabel.Text = "【完了】 保存先：" + savePath;
            }
            catch
            {
                resultLabel.Text = "【エラー】";
            }
            finally
            {
                if (topRight != null) topRight.Dispose();
                if (topLeft != null) topLeft.Dispose();
                if (bottomRight != null) bottomRight.Dispose();
                if (bottomLeft != null) bottomLeft.Dispose();
                if (top != null) top.Dispose();
                if (bottom != null) bottom.Dispose();
                if (complete != null) complete.Dispose();
            }
        }

        /// <summary>
        /// CheckHasImage
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="cnt"></param>
        /// <returns></returns>
        private Bitmap CheckHasImage(PictureBox pb, ref int cnt)
        {
            Bitmap result = null;
            if (pb != null && pb.Image != null)
            {
                result = (Bitmap)pb.Image;
                cnt++;
            }
            return result;
        }

        /// <summary>
        /// OnClickExit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// OnDragDropPictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDragDropPictureBox(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Image != null)
            {
                pb.Image.Dispose();
            }
            pb.Image = null;

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (file.Length != 1)
            {
                ShowErrorMessae("画像ファイルは1つずつ選択してください");
                return;
            }
            
            ((PictureBox)sender).Image = CreateImage(file[0]);
        }

        /// <summary>
        /// CreateImage
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private Image CreateImage(string filename)
        {
            System.IO.FileStream fs = new System.IO.FileStream(
                filename,
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            Image img = Image.FromStream(fs);
            fs.Close();
            return img;
        }

        /// <summary>
        /// OnDragEnterPictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDragEnterPictureBox(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        /// <summary>
        /// ShowYesNoMessae
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private DialogResult ShowYesNoMessae(string message)
        {
            return MessageBox.Show(message, "ImageBond", MessageBoxButtons.YesNo);
        }

        /// <summary>
        /// ShowErrorMessae
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private DialogResult ShowErrorMessae(string message)
        {
            return MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// OnClickShowVersionInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickShowVersionInfo(object sender, EventArgs e)
        {
            VersionInfoModal f = new VersionInfoModal()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(this);
            f.Dispose();
        }

        /// <summary>
        /// OnClickCustomizeResolution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickCustomizeResolution(object sender, EventArgs e)
        {
            CustomizeResolutionModal f = new CustomizeResolutionModal()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(this);
            f.Dispose();
        }

        /// <summary>
        /// OnClickCustomizeCrop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickCustomizeCrop(object sender, EventArgs e)
        {
            CustomizeCropModal f = new CustomizeCropModal()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(this);
            f.Dispose();
        }

        /// <summary>
        /// OnClickSetSaveDirectoryMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickSetSaveDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "保存先フォルダを選択してください",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = saveDirectory
            };
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                saveDirectory = fbd.SelectedPath;
            }
        }

        /// <summary>
        /// OpeningContextMenuStripForResetImage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpeningContextMenuStripForResetImage(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ContextMenuStrip menu = (ContextMenuStrip)sender;
            Control source = menu.SourceControl;
            if (source != null)
            {
                PictureBox pb = (PictureBox)source;
                if (pb.Image != null)
                {
                    pb.Image.Dispose();
                }
                pb.Image = null;
            }
        }
    }
}
