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
    public class EightBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette.Colors.Count != 256)
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
            EightBppBitmap bitmap = new EightBppBitmap(Drawer.GetImageSize(file.Length), file, palette.Colors.ToArray());
            return bitmap.ToBitmap(worker);
        }
    }
}
