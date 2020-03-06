using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meduris
{
    public sealed class Utils
    {

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        public static bool compareBitMap(Bitmap bmp1, Bitmap bmp2)
        {

            if (bmp1 == null || bmp2 == null)
                return false;
            for (int colone = 0; colone < bmp1.Width; colone++)
            {
                for (int rangee = 0; rangee < bmp1.Height; rangee++)
                {
                    if (!bmp1.GetPixel(colone, rangee).Equals(bmp2.GetPixel(colone, rangee)))
                        return false;
                }
            }

            return true;
        }
    }
}
