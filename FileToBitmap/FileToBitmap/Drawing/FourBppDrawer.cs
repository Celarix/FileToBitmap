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
    public class FourBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette.Colors.Count != 16)
            {
                throw new Exception("Palette mismatch.");
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
            byte[] pixels = new byte[file.Length * 2];

            file.Length.Times(i =>
            {
                pixels[(i * 2)] = (byte)(file[i] >> 4);
                pixels[(i * 2) + 1] = (byte)(file[i] & 0xF);
            });

            FourBppBitmap bitmap = new FourBppBitmap(Drawer.GetImageSize(pixels.Length), pixels, palette.Colors.ToArray<Color>());
            return bitmap.ToBitmap(worker);
        }
    }
}
