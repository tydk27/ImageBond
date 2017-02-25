using System.Drawing;

namespace ImageBond
{
    /// <summary>
    /// MakeImageClass
    /// </summary>
    public class MakeImage
    {
        /// <summary>
        /// crop image
        /// </summary>
        /// <param name="img"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Bitmap CropImage(Bitmap img, int x, int y)
        {
            int width = img.Width - x * 2;
            int height = img.Height - y * 2;

            Rectangle rectangle = new Rectangle(x, y, width, height);
            Bitmap image = img.Clone(rectangle, img.PixelFormat);

            return image;
        }

        /// <summary>
        /// resize image
        /// </summary>
        /// <param name="img"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap ResizeImage(Bitmap img, int width, int height)
        {
            Bitmap image = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(image);

            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(img, 0, 0, width, height);
            graphics.Dispose();

            return image;
        }

        /// <summary>
        /// chain image
        /// </summary>
        /// <param name="img1"></param>
        /// <param name="img2"></param>
        /// <param name="chainFlg"></param>
        /// <returns></returns>
        public Bitmap ChainImage(Bitmap img1, Bitmap img2, bool chainFlg)
        {
            int width, height = 0;

            // trueの場合は画像を横に結合する
            if (chainFlg == true)
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

            Bitmap image = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(image);

            graphics.DrawImage(img1, new Point(0, 0));

            Point point = (chainFlg == true) ? new Point(img1.Width, 0) : new Point(0, img1.Height);
            graphics.DrawImage(img2, point);
            graphics.Dispose();

            return image;
        }

        /// <summary>
        /// GetImageFormat
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public System.Drawing.Imaging.ImageFormat GetImageFormat(string extension)
        {
            System.Drawing.Imaging.ImageFormat format = null;
            switch (extension)
            {
                case ".bmp":
                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                case ".gif":
                    format = System.Drawing.Imaging.ImageFormat.Gif;
                    break;
                case ".jpg":
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case ".png":
                    format = System.Drawing.Imaging.ImageFormat.Png;
                    break;
            }
            return format;
        }

    }
}
