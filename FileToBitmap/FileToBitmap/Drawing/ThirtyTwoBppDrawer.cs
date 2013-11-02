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
    public class ThirtyTwoBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette != null)
            {
                throw new Exception("32bpp mode does not support palettes.");
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

            if (file.Length % 4 == 0)
            {
                pixels = new int[file.Length / 4];
            }
            else
            {
                int pixelCount = file.Length / 4;
                while (pixelCount % 4 != 0)
                {
                    pixelCount++;
                }
                pixels = new int[pixelCount];
            }

            byte alpha, red, green, blue;
            for (int i = 0; i < pixels.Length; i++)
            {
                alpha = (byte)((i * 4 < file.Length) ? file[i * 4] : 0);
                red = (byte)((((i * 4) + 1) < file.Length) ? file[(i * 4) + 1] : 0);
                green = (byte)((((i * 4) + 2) < file.Length) ? file[(i * 4) + 2] : 0);
                blue = (byte)((((i * 4) + 3) < file.Length) ? file[(i * 4) + 3] : 0);
                pixels[i] = (alpha << 24) + (red << 16) + (green << 8) + blue;
            }

            return new ThirtyTwoBppBitmap(Drawer.GetImageSize(pixels.Length), pixels).ToBitmap(worker);
        }
    }
}
