using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FileToBitmap.Drawing
{
    public abstract class BitmapBase
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public abstract int[,] To32BppArray();

        public unsafe Bitmap ToBitmap(BackgroundWorker worker)
        {
            var pixels = this.To32BppArray();

            Bitmap bitmap = new Bitmap(pixels.GetUpperBound(1) + 1, pixels.GetUpperBound(0) + 1, PixelFormat.Format24bppRgb);
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;

            byte[] bytes = new byte[stride * bitmap.Height];
            for (int r = 0; r < bitmap.Height; r++)
            {
                for (int c = 0; c < bitmap.Width; c++)
                {
                    Color color = Color.FromArgb(pixels[r, c]);
                    bytes[(r * stride) + c * 3] = color.B;
                    bytes[(r * stride) + c * 3 + 1] = color.G;
                    bytes[(r * stride) + c * 3 + 2] = color.R;
                }

                if (worker.CancellationPending)
                {
                    break;
                }
                worker.ReportProgress((int)(((decimal)r / (decimal)bitmap.Height) * 100m));
            }

            IntPtr scan0 = data.Scan0;
            Marshal.Copy(bytes, 0, scan0, stride * bitmap.Height);
            bitmap.UnlockBits(data);
            return bitmap;
        }
    }
}
