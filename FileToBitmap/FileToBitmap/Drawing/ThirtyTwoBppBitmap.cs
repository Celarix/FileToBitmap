﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using FileToBitmap.Colors;

namespace FileToBitmap.Drawing
{
    public class ThirtyTwoBppBitmap : BitmapBase
    {
        private int[] pixels;

        public ThirtyTwoBppBitmap(Size size, int[] pixels)
        {
            this.Width = size.Width;
            this.Height = size.Height;
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
                    result[x, y] = (i < pixels.Length) ? pixels[i] : 0;
                    i++;
                }
            }

            return result;
        }
    }
}
