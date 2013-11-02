using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using FileToBitmap.Colors;

namespace FileToBitmap.Drawing
{
    public class OneBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette.Colors.Count != 2)
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

            BitArray bits = new BitArray(File.ReadAllBytes(filePath));
            OneBppBitmap bitmap = new OneBppBitmap(Drawer.GetImageSize(bits.Length), bits, palette.GetColor(0), palette.GetColor(1));
            return bitmap.ToBitmap(worker);
        }
    }
}
