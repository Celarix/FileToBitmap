using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.ComponentModel;
using FileToBitmap.Colors;

namespace FileToBitmap.Drawing
{
    public class TwoBppDrawer : Drawer
    {
        public override Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker)
        {
            if (palette.Colors.Count != 4)
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

            byte[] bytes = File.ReadAllBytes(filePath);
            byte[] twoBppValues = new byte[bytes.Length * 4];

            bytes.Length.Times(i =>
            {
                twoBppValues[(i * 4)] = (byte)((bytes[i] & 0xC0) >> 6);
                twoBppValues[(i * 4) + 1] = (byte)((bytes[i] & 0x30) >> 4);
                twoBppValues[(i * 4) + 2] = (byte)((bytes[i] & 0x0C) >> 2);
                twoBppValues[(i * 4) + 3] = (byte)((bytes[i] & 0x03));
            });

            TwoBppBitmap bitmap = new TwoBppBitmap(Drawer.GetImageSize(twoBppValues.Length), twoBppValues, palette.GetColor(0), palette.GetColor(1), palette.GetColor(2), palette.GetColor(3));
            return bitmap.ToBitmap(worker);
        }
    }
}
