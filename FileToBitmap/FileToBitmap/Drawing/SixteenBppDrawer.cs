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
    public class SixteenBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette != null)
            {
                throw new Exception("16bpp mode doesn't accept palettes.");
            }

            if (!File.Exists(filePath))
            {
                throw new Exception("File not found.");
            }

            if (new FileInfo(filePath).Length == 0)
            {
                return new Bitmap(0, 0);
            }

            byte[] file = File.ReadAllBytes(filePath);
            ushort[] pixels;
            if (file.Length % 2 == 0)
            {
                pixels = new ushort[file.Length / 2];
            }
            else
            {
                pixels = new ushort[file.Length / 2 + 1];
            }

            for (int i = 0; i < file.Length; i += 2)
            {
                if (i + 1 < file.Length)
                {
                    int pixelIndex = i / 2;
                    pixels[pixelIndex] = (ushort)((file[i] << 8) + file[i + 1]);
                }
                else
                {
                    int pixelIndex = i / 2;
                    pixels[pixelIndex] = (ushort)(file[i] << 8);
                }
            }

            return new SixteenBppBitmap(Drawer.GetImageSize(pixels.Length), pixels).ToBitmap(worker);
        } 
    }
}
