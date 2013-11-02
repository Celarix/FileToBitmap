using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using FileToBitmap.Colors;

namespace FileToBitmap.Drawing
{
    public class TwentyFourBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette != null)
            {
                throw new Exception("24bpp mode does not accept palette.");
            }

            if (!File.Exists(filePath))
            {
                throw new Exception("File does not exist.");
            }

            if (new FileInfo(filePath).Length == 0)
            {
                return new Bitmap(0, 0);
            }

            byte[] file = File.ReadAllBytes(filePath);
            int[] pixels;

            if (file.Length % 3 == 0)
            {
                pixels = new int[file.Length / 3];
            }
            else
            {
                int pixelCount = (int)Math.Floor(file.Length / 3m);
                while (pixelCount % 3 != 0)
                {
                    pixelCount++;
                }
                pixels = new int[pixelCount];
            }

            byte red, green, blue;
            for (int i = 0; i < pixels.Length; i++)
            {
                // Pattern: xxRRGGBB
                // Red byte comes from file[i * 3] shifted by 16
                // Green byte comes from file[(i * 3) + 1] shifted by 8
                // Blue byte comes from file[(i * 3) + 2] shifted by 8
                red = (byte)((i * 3 < file.Length) ? file[i * 3] : 0);
                green = (byte)((((i * 3) + 1) < file.Length) ? file[(i * 3) + 1] : 0);
                blue = (byte)((((i * 3) + 2) < file.Length) ? file[(i * 3) + 2] : 0);
                pixels[i] = (red << 16) + (green << 8) + blue;
            }

            return new TwentyFourBppBitmap(Drawer.GetImageSize(pixels.Length), pixels).ToBitmap(worker);
        }
    }
}
