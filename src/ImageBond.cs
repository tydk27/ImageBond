using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBond
{
    public partial class ImageBond : Form
    {
        InifileUtils ini = new InifileUtils("./ImageBond.ini");

        private int FileFilter;

        private string Picture1;
        private string Picture2;
        private string Picture3;
        private string Picture4;

        public ImageBond()
        {
            InitializeComponent();
        }

        private void ImageBond_Load(object sender, EventArgs e)
        {
            this.pictureBox1.AllowDrop = true;
            this.pictureBox2.AllowDrop = true;
            this.pictureBox3.AllowDrop = true;
            this.pictureBox4.AllowDrop = true;

            this.intX.Text = ini["conf", "intX_crop"];
            this.intY.Text = ini["conf", "intY_crop"];
            this.preWidth.Text = ini["conf", "preWidth_resize"];
            this.preHeight.Text = ini["conf", "preHeight_resize"];
            this.postWidth.Text = ini["conf", "postWidth_resize"];
            this.postHeight.Text = ini["conf", "postHeight_resize"];
            this.saveFolderTextBox.Text = ini["conf", "saveFolder"];
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            string saveFile;
            if (this.saveFolderTextBox.Text.Length == 0)
            {
                string appPath = System.Windows.Forms.Application.StartupPath;
                saveFile = System.IO.Path.Combine(appPath + "\\output.jpeg");
                this.FileFilter = 3;
            }
            else
            {
                saveFile = this.saveFolderTextBox.Text;
                string stExtension = System.IO.Path.GetExtension(saveFile);
                this.SetFileFilter(stExtension);
            }

            if (System.IO.File.Exists(saveFile))
            {
                DialogResult result = this.showQuestionMessae("既にファイルが存在します。上書きしますか？");
                if (result == DialogResult.No) return;
            }

            try
            {
                System.Drawing.Imaging.ImageFormat format;

                int cropX = int.Parse(this.intX.Text);
                int cropY = int.Parse(this.intY.Text);

                int preWid = int.Parse(this.preWidth.Text);
                int preHei = int.Parse(this.preHeight.Text);
                int postWid = int.Parse(this.postWidth.Text);
                int postHei = int.Parse(this.postHeight.Text);

                Bitmap upImgRight = new Bitmap(this.Picture1);
                Bitmap upImgLeft = new Bitmap(this.Picture2);
                Bitmap downImgRight = new Bitmap(this.Picture3);
                Bitmap downImgLeft = new Bitmap(this.Picture4);

                upImgRight = this.ImgProceed(upImgRight, cropX, cropY, preWid, preHei);
                upImgLeft = this.ImgProceed(upImgLeft, cropX, cropY, preWid, preHei);
                downImgRight = this.ImgProceed(downImgRight, cropX, cropY, preWid, preHei);
                downImgLeft = this.ImgProceed(downImgLeft, cropX, cropY, preWid, preHei);

                Bitmap upImg = this.ChainPicture(upImgRight, upImgLeft, true);
                Bitmap downImg = this.ChainPicture(downImgRight, downImgLeft, true);

                Bitmap compImg = this.ChainPicture(upImg, downImg, false);

                compImg = this.ResizePicture(compImg, postWid, postHei);

                format = this.SetImgFormat();
                compImg.Save(saveFile, format);

                upImgRight.Dispose();
                upImgLeft.Dispose();
                downImgRight.Dispose();
                downImgLeft.Dispose();

                upImg.Dispose();
                downImg.Dispose();

                compImg.Dispose();

                this.showMessae("画像を生成しました。");

                string savePath = System.IO.Path.GetDirectoryName(saveFile);
                System.Diagnostics.Process.Start(@savePath);
            }
            catch
            {
                this.showErrorMessae("画像の生成に失敗しました。");
            }
        }

        private Bitmap ImgProceed(Bitmap img, int x, int y, int width, int height)
        {
            img = this.CropPicture(img, x, y);
            img = this.ResizePicture(img, width, height);

            return img;
        }

        private Bitmap CropPicture(Bitmap img, int x, int y)
        {
            int dstWid = img.Width - x * 2;
            int dstHei = img.Height - y * 2;

            Rectangle rect = new Rectangle(x, y, dstWid, dstHei);
            Bitmap croppedImg = img.Clone(rect, img.PixelFormat);

            img.Dispose();

            return croppedImg;
        }

        private Bitmap ResizePicture(Bitmap img, int width, int height)
        {
            Bitmap resizedImg = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(resizedImg);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return resizedImg;
        }

        private Bitmap ChainPicture(Bitmap img1, Bitmap img2, bool flg)
        {
            int width, height;

            // trueの場合は画像を横に結合する
            if( flg == true )
            {
                width = img1.Width + img2.Width;
                height = img1.Height > img2.Height ? img1.Height : img2.Height;
            }
            // falseの場合は画像を縦に結合する
            else
            {
                width = img1.Width > img2.Width ? img1.Width : img2.Width;
                height = img1.Height + img2.Height;
            }
            
            Bitmap img3 = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img3);

            g.DrawImage(img1, new Point(0, 0));

            if( flg == true )
            {
                g.DrawImage(img2, new Point(img1.Width, 0));
            }
            else
            {
                g.DrawImage(img2, new Point(0, img1.Height));
            }

            g.Dispose();

            return img3;
        }

        private void SetFileFilter(string ext)
        {
            switch (ext)
            {
                case "bmp":
                    this.FileFilter = 1;
                    break;
                case "gif":
                    this.FileFilter = 2;
                    break;
                case "jpeg":
                    this.FileFilter = 3;
                    break;
                case "png":
                    this.FileFilter = 4;
                    break;
            }
        }

        private System.Drawing.Imaging.ImageFormat SetImgFormat()
        {
            System.Drawing.Imaging.ImageFormat format;

            if (this.FileFilter == 1)
            {
                return format = System.Drawing.Imaging.ImageFormat.Bmp;
            }
            else if (this.FileFilter == 2)
            {
                return format = System.Drawing.Imaging.ImageFormat.Gif;
            }
            else if (this.FileFilter == 3)
            {
                return format = System.Drawing.Imaging.ImageFormat.Jpeg;
            }
            else if (this.FileFilter == 4)
            {
                return format = System.Drawing.Imaging.ImageFormat.Png;
            }
            else
            {
                return null;
            }
        }

        private void SelectSaveFolderButton_Click(object sender, EventArgs e)
        {
            string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = stCurrentDir;
            sfd.Filter = "Bitmap Image |*.bmp|Gif Image |*.gif|JPEG Image |*.jpeg|Png Image |*.png";
            sfd.FilterIndex = 3;
            sfd.Title = "保存先のファイルを選択してください。";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.saveFolderTextBox.Text = sfd.FileName;
                this.FileFilter = sfd.FilterIndex;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionInfo vi = new VersionInfo();
            vi.ShowDialog(this);
            vi.Dispose();
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (fileName.Length != 1) return;

                PictureBox pictTarget = sender as PictureBox;

                System.Drawing.Graphics g = pictTarget.CreateGraphics();
                Bitmap pictureFile = new Bitmap(fileName[0]);
                pictureFile = this.ImgProceed(pictureFile,
                                              int.Parse(intX.Text),
                                              int.Parse(intY.Text),
                                              pictTarget.Width,
                                              pictTarget.Height);
                pictTarget.Refresh();
                g.DrawImage(pictureFile, new System.Drawing.Point(0, 0));

                if (pictTarget == this.pictureBox1) this.Picture1 = fileName[0];
                if (pictTarget == this.pictureBox2) this.Picture2 = fileName[0];
                if (pictTarget == this.pictureBox3) this.Picture3 = fileName[0];
                if (pictTarget == this.pictureBox4) this.Picture4 = fileName[0];

                pictureFile.Dispose();
            }
            catch
            {
                this.showErrorMessae("ファイルの読込に失敗しました。");
            }
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Refresh();
            this.pictureBox2.Refresh();
            this.pictureBox3.Refresh();
            this.pictureBox4.Refresh();
            this.Picture1 = "";
            this.Picture2 = "";
            this.Picture3 = "";
            this.Picture4 = "";
        }

        private void TextBox_TextCanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "intX":
                    ini["conf", "intX_crop"] = tb.Text;
                    break;
                case "intY":
                    ini["conf", "intY_crop"] = tb.Text;
                    break;
                case "preWidth":
                    ini["conf", "preWidth_resize"] = tb.Text;
                    break;
                case "preHeight":
                    ini["conf", "preHeight_resize"] = tb.Text;
                    break;
                case "postWidth":
                    ini["conf", "postWidth_resize"] = tb.Text;
                    break;
                case "postHeight":
                    ini["conf", "postHeight_resize"] = tb.Text;
                    break;
                case "saveFolderTextBox":
                    ini["conf", "saveFolder"] = tb.Text;
                    break;
            }
        }

        private DialogResult showMessae(string message)
        {
            return MessageBox.Show(message, "ImageBond", MessageBoxButtons.OK);
        }

        private DialogResult showQuestionMessae(string message)
        {
            return MessageBox.Show(message, "ImageBond", MessageBoxButtons.YesNo);
        }

        private DialogResult showErrorMessae(string message)
        {
            return MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
