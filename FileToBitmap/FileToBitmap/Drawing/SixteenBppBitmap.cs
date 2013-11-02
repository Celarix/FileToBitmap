using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using FileToBitmap.Colors;

namespace FileToBitmap.Drawing
{
    public class SixteenBppBitmap : BitmapBase
    {
        private ushort[] pixels;

        public SixteenBppBitmap(Size size, ushort[] pixels)
        {
            this.Width = size.Width;
            this.Height = size.Height;
            this.pixels = pixels;
        }

        public override int[,] To32BppArray()
        {
            int[,] result = new int[Width, Height];

            int i = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (i >= pixels.Length)
                    {
                        result[x, y] = 0;
                    }
                    else
                    {
                        result[x, y] = Palette.Get16BitColor(pixels[i]).ToArgb();
                    }
                    i++;
                }
            }

            return result;
        }
    }
}
