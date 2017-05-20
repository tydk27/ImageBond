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
        /// init
        /// </summary>
        public ImageBondForm()
        {
            InitializeComponent();

            mi = new MakeImageClass();
        }

        /// <summary>
        /// OnClickOutput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickOutput(object sender, EventArgs e)
        {
            string outputFileName = outputPathBox.Text;
            if (string.IsNullOrEmpty(outputFileName))
            {
                outputFileName = System.IO.Path.Combine(Application.StartupPath + "\\output.jpg");
            }

            if (System.IO.File.Exists(outputFileName))
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

            Bitmap topRight = null;
            Bitmap topLeft = null;
            Bitmap bottomRight = null;
            Bitmap bottomLeft = null;
            Bitmap top = null;
            Bitmap bottom = null;
            Bitmap complete = null;
            
            topRight = (topRightBox != null || topRightBox.Image != null) ? (Bitmap)topRightBox.Image : null;
            topLeft = (topLeftBox != null || topLeftBox.Image != null) ? (Bitmap)topLeftBox.Image : null;
            bottomRight = (bottomRightBox != null || bottomRightBox.Image != null) ? (Bitmap)bottomRightBox.Image : null;
            bottomLeft = (bottomLeftBox != null || bottomLeftBox.Image != null) ? (Bitmap)bottomLeftBox.Image : null;
            
            try
            {
                topRight = mi.CropImage(topRight, cropX, cropY);
                topLeft = mi.CropImage(topLeft, cropX, cropY);
                top = mi.ChainImage(topRight, topLeft, true);

                bottomRight = mi.CropImage(bottomRight, cropX, cropY);
                bottomLeft = mi.CropImage(bottomLeft, cropX, cropY);
                bottom = mi.ChainImage(bottomRight, bottomLeft, true);

                complete = mi.ChainImage(top, bottom, false);
                complete = mi.ResizeImage(complete, width, height);

                System.Drawing.Imaging.ImageFormat format = mi.GetImageFormat(System.IO.Path.GetExtension(outputFileName));
                complete.Save(outputFileName, format);

                string savePath = System.IO.Path.GetDirectoryName(outputFileName);
                System.Diagnostics.Process.Start(@savePath);
            }
            catch
            {
                ShowErrorMessae("作成に失敗しました");
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
        /// OnClickSelectFolder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickSelectFolder(object sender, EventArgs e)
        {
            SaveFileDialog sfd = null;
            sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            sfd.Filter = "Bitmap Image |*.bmp|Gif Image |*.gif|JPEG Image |*.jpg|Png Image |*.png";
            sfd.FilterIndex = 3;
            sfd.Title = "保存先を選択";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                outputPathBox.Text = sfd.FileName;
            }
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
            ((PictureBox)sender).Image = null;

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (file.Length != 1)
            {
                ShowErrorMessae("画像ファイルは1つずつ選択してください");
                return;
            }

            ((PictureBox)sender).Image = Image.FromFile(file[0]);
        }

        /// <summary>
        /// PictureBox_DragEnter
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
            VersionInfoModal f = new VersionInfoModal();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
            f.Dispose();
        }

        /// <summary>
        /// onClickCustomizeResolution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickCustomizeResolution(object sender, EventArgs e)
        {
            CustomizeResolutionModal f = new CustomizeResolutionModal();
            f.StartPosition = FormStartPosition.CenterParent;
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
            CustomizeCropModal f = new CustomizeCropModal();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
            f.Dispose();
        }
    }
}
