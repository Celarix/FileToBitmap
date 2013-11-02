using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FileToBitmap.Drawing
{
    internal class TwoBppBitmap : BitmapBase
    {
        private Color[] colors;

        private byte[] pixels;

        public TwoBppBitmap(Size size, byte[] pixels, Color zero, Color one, Color two, Color three)
        {
            this.Width = size.Width;
            this.Height = size.Height;
            this.colors = new Color[] { zero, one, two, three };
            this.pixels = pixels;
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
