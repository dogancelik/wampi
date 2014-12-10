using System.Drawing;
using System.Drawing.Drawing2D;

namespace Wampi
{
    internal static class ImageUtils
    {
        static public Image Resize(object source, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage((Image)source, 0, 0, bitmap.Width, bitmap.Height);
            graphics.Dispose();
            return bitmap;
        }
    }
}