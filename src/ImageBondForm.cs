using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageBond
{
    /// <summary>
    /// ImageBondForm
    /// </summary>
    public partial class ImageBondForm : Form
    {
        /// <summary>
        /// MakeImage
        /// </summary>
        MakeImage mi = null;

        /// <summary>
        /// VersionInfoForm
        /// </summary>
        VersionInfoForm vi = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public ImageBondForm()
        {
            InitializeComponent();

            mi = new MakeImage();
            vi = new VersionInfoForm();
        }

        /// <summary>
        /// OutputButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputButton_Click(object sender, EventArgs e)
        {
            string outputFileName = output.Text;
            if (string.IsNullOrEmpty(outputFileName))
            {
                outputFileName = System.IO.Path.Combine(Application.StartupPath + "\\output.jpg");
            }

            if (System.IO.File.Exists(outputFileName))
            {
                DialogResult dialogResult = showYesNoMessae("既にファイルが存在します。上書きしますか？");
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            int cropX = int.Parse(this.cropX.Text);
            int cropY = int.Parse(this.cropY.Text);
            int width = int.Parse(this.width.Text);
            int height = int.Parse(this.height.Text);

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
                showErrorMessae("作成に失敗しました。");
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
        /// SelectSaveFolderButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSaveFolderButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            sfd.Filter = "Bitmap Image |*.bmp|Gif Image |*.gif|JPEG Image |*.jpg|Png Image |*.png";
            sfd.FilterIndex = 3;
            sfd.Title = "保存先を選択";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                output.Text = sfd.FileName;
            }
        }

        /// <summary>
        /// ExitToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// VersionToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vi.ShowDialog();
        }

        /// <summary>
        /// PictureBox_DragDrop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            ((PictureBox)sender).Image = null;

            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (file.Length != 1)
            {
                showErrorMessae("画像は1つずつ選択してください。");
                return;
            }

            ((PictureBox)sender).Image = Image.FromFile(file[0]);
        }

        /// <summary>
        /// PictureBox_DragEnter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        /// <summary>
        /// resetButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            topRightBox.Image = null;
            topLeftBox.Image = null;
            bottomRightBox.Image = null;
            bottomLeftBox.Image = null;
        }

        /// <summary>
        /// showMessae
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private DialogResult showMessae(string message)
        {
            return MessageBox.Show(message, "ImageBond", MessageBoxButtons.OK);
        }

        /// <summary>
        /// showYesNoMessae
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private DialogResult showYesNoMessae(string message)
        {
            return MessageBox.Show(message, "ImageBond", MessageBoxButtons.YesNo);
        }

        /// <summary>
        /// showErrorMessae
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private DialogResult showErrorMessae(string message)
        {
            return MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ImageBondForm_Load(object sender, EventArgs e)
        {

        }
    }
}
