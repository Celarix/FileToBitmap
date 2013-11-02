using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FileToBitmap.Drawing
{
    internal class OneBppBitmap : BitmapBase
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        private Color zero;
        private Color one;

        private BitArray bits;

        public OneBppBitmap(Size size, BitArray bits, Color zero, Color one)
        {
            this.Width = size.Width;
            this.Height = size.Height;
            this.zero = zero;
            this.one = one;
            this.bits = bits;
        }

        public override int[,] To32BppArray()
        {
            int[,] result = new int[this.Width, this.Height];

            int i = 0;
            for (int y = 0; y < this.Height; y++)
            {
                for (int x = 0; x < this.Width; x++)
                {
                    if (i >= bits.Length)
                    {
                        result[x, y] = this.zero.ToArgb();
                    }
                    else if (!bits[i])
                    {
                        result[x, y] = this.zero.ToArgb();
                    }
                    else if (bits[i])
                    {
                        result[x, y] = this.one.ToArgb();
                    }
                    i++;
                }
            }

            return result;
        }
    }
}
