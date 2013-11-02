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
    public abstract class Drawer
    {
        public abstract Bitmap Draw(string filePath, Palette palette, BackgroundWorker worker);

        protected static Size GetImageSize(int pixelCount)
        {
            int squareRoot = (int)Math.Sqrt(pixelCount);     
       
            if (pixelCount.IsPerfectSquare())
            {
                return new Size(squareRoot, squareRoot);
            }
            else
            {
                int height = squareRoot;
                int remainder = pixelCount - (squareRoot * squareRoot);
                int remainderRows = (int)Math.Ceiling((double)remainder / squareRoot);

                while (remainderRows > 0)
                {
                    height++;
                    remainderRows--;
                }

                return new Size(squareRoot, height);
            }
        }
    }
}
