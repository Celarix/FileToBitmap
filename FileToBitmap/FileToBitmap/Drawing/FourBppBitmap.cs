using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using FileToBitmap.Colors;

namespace FileToBitmap.Drawing
{
    internal class FourBppBitmap : BitmapBase
    {
        private Color[] colors;
        private byte[] pixels;

        public FourBppBitmap(Size size, byte[] pixels, Color[] colors)
        {
            this.Width = size.Width;
            this.Height = size.Height;
            this.pixels = pixels;
            this.colors = colors;
        }

        public override int[,] To32BppArray()
        {
            int[,] result = new int[this.Width, this.Height];

            int i = 0;
            for (int y = 0; y < this.Height; y++)
            {
                for (int x = 0; x < this.Width; x++)
                {
                    if (i >= this.pixels.Length)
                    {
                        result[x, y] = this.colors[0].ToArgb();
                    }
                    else
                    {
                        result[x, y] = this.colors[this.pixels[i]].ToArgb();
                    }
                    i++;
                }
            }

            return result;
        }
    }
}
