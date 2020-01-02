using System.Drawing;

namespace ImageBond.Main
{
    public class ImageEdit
    {
        private Bitmap _original { get; set; }

        private Bitmap _edited { get; set; }

        public ImageEdit(Bitmap img)
        {
            _original = img;
        }

        public void Dispose()
        {
            if (_original != null)
            {
                _original.Dispose();
            }
            if (_edited != null)
            {
                _edited.Dispose();
            }
        }

        public Bitmap GetImage()
        {
            if (_edited == null)
            {
                return _original;
            }
            else
            {
                return _edited;
            }
        }

        public void Crop(int x, int y)
        {
            int width = GetImage().Width - (x * 2);
            int height = GetImage().Height - (y * 2);

            Bitmap image = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(image);
            g.DrawImage(GetImage(), -x, -y);
            g.Dispose();

            if (_edited != null)
            {
                _edited.Dispose();
            }
            _edited = image;
        }

        public void Resize(int width, int height)
        {
            Bitmap image = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(image);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(GetImage(), 0, 0, width, height);
            g.Dispose();

            if (_edited != null)
            {
                _edited.Dispose();
            }
            _edited = image;
        }

        public Bitmap Chain(Bitmap target, bool chainFlag)
        {
            if (target == null)
            {
                throw new System.ArgumentException("args is null", "img");
            }

            int width, height = 0;

            // trueの場合は画像を横に結合する
            if (chainFlag == true)
            {
                width = GetImage().Width + target.Width;
                height = GetImage().Height > target.Height ? GetImage().Height : target.Height;
            }
            // falseの場合は画像を縦に結合する
            else
            {
                width = GetImage().Width > target.Width ? GetImage().Width : target.Width;
                height = GetImage().Height + target.Height;
            }

            Bitmap result = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(result);

            g.DrawImage(GetImage(), new Point(0, 0));

            Point point = chainFlag == true ? new Point(GetImage().Width, 0) : new Point(0, GetImage().Height);
            g.DrawImage(target, point);
            g.Dispose();

            return result;
        }
    }
}
