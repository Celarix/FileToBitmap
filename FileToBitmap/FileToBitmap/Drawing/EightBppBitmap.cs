using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FileToBitmap.Drawing
{
    public class EightBppBitmap : BitmapBase
    {
        private Color[] colors;
        private byte[] pixels;

        public EightBppBitmap(Size size, byte[] pixels, Color[] colors)
        {
            this.Width = size.Width;
            this.Height = size.Height;
            this.pixels = pixels;
            this.colors = colors;
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
                        result[x, y] = colors[0].ToArgb();
                    }
                    else
                    {
                        result[x, y] = colors[pixels[i]].ToArgb();
                    }
                    i++;
                }
            }

            return result;
        }
    }
}
