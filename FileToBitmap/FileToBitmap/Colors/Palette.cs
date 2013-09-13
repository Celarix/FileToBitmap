using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FileToBitmap.Colors
{
    public sealed class Palette
    {
        private Color[] colors;

        // used for getting 16-bit colors
        // (5 bits red, 6 bits green, 5 bits blue)
        private static Dictionary<int, int> sixBitRange;
        private static Dictionary<int, int> fiveBitRange;

        public static Palette OneBppDefaultPalette;
        public static Palette TwoBppGrayscalePalette;
        public static Palette FourBppGrayscalePalette;
        public static Palette FourBppWindowsPalette;
        public static Palette EightBppGrayscalePalette;
        public static Palette EightBppColorPalette;

        private static bool hasAssignedPalettes = false;

        public BitDepth BitDepth { get; private set; }
        public ReadOnlyCollection<Color> Colors
        {
            get
            {
                return new ReadOnlyCollection<Color>(colors);
            }
        }

        static Palette()
        {
            Palette.OneBppDefaultPalette = new Palette(BitDepth.OneBpp);
        }

        public Palette(BitDepth bitDepth)
        {
            this.BitDepth = bitDepth;

            switch (this.BitDepth)
            {
                case BitDepth.OneBpp:
                    this.colors = new Color[2];
                    break;
                case BitDepth.TwoBpp:
                    this.colors = new Color[4];
                    break;
                case BitDepth.FourBpp:
                    this.colors = new Color[16];
                    break;
                case BitDepth.EightBpp:
                    this.colors = new Color[256];
                    break;
                default:
                    throw new Exception(String.Format("Invalid bit depth {0}", bitDepth.ToString()));
            }

            if (!hasAssignedPalettes)
            {
                this.AssignPalettes();
            }
        }

        public Color GetColor(int index)
        {
            if (index < 0 || index >= this.colors.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return this.colors[index];
        }

        public void SetColor(int index, Color value)
        {
            if (index < 0 || index >= this.colors.Length)
            {
                throw new IndexOutOfRangeException();
            }

            this.colors[index] = value;
        }

        private void AssignPalettes()
        {
            hasAssignedPalettes = true;

            sixBitRange = this.GetEquidistantHexValues(64);
            fiveBitRange = this.GetEquidistantHexValues(32);

            OneBppDefaultPalette = new Palette(BitDepth.OneBpp);
            TwoBppGrayscalePalette = new Palette(BitDepth.TwoBpp);
            FourBppGrayscalePalette = new Palette(BitDepth.FourBpp);
            FourBppWindowsPalette = new Palette(BitDepth.FourBpp);
            EightBppGrayscalePalette = new Palette(BitDepth.EightBpp);
            EightBppColorPalette = new Palette(BitDepth.EightBpp);

            // Assign OneBppDefaultPalette
            OneBppDefaultPalette.SetColor(0, Color.Black);
            OneBppDefaultPalette.SetColor(1, Color.White);

            // Assign TwoBppGrayscalePalette
            TwoBppGrayscalePalette.SetColor(0, Color.Black);
            TwoBppGrayscalePalette.SetColor(1, Color.FromArgb(85, 85, 85));
            TwoBppGrayscalePalette.SetColor(2, Color.FromArgb(170, 170, 170));
            TwoBppGrayscalePalette.SetColor(3, Color.White);

            // Assign FourBppGrayscalePalette
            FourBppGrayscalePalette.SetColor(0, Color.Black);
            for (int i = 1; i <= 14; i++)
            {
                FourBppGrayscalePalette.SetColor(i, Color.FromArgb(i * 18, i * 18, i * 18));
            }
            FourBppGrayscalePalette.SetColor(15, Color.White);

            // Assign FourBppWindowsPalette
            int[] reds = new int[] { 0x00, 0x80, 0x00, 0x80, 0x00, 0x80, 0x00, 0xC0, 0x80, 0xFF, 0x00, 0xFF, 0x00, 0xA7, 0x00, 0xFF };
            int[] greens = new int[] { 0x00, 0x00, 0x80, 0x80, 0x00, 0x00, 0x80, 0xC0, 0x80, 0x00, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF };
            int[] blues = new int[] { 0x00, 0x00, 0x00, 0x00, 0x80, 0x80, 0x80, 0xC0, 0x80, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF };
            for (int i = 0; i < 16; i++)
            {
                FourBppWindowsPalette.SetColor(i, Color.FromArgb(reds[i], greens[i], blues[i]));
            }

            // Assign EightBppGrayscalePalette
            for (int i = 0; i < 256; i++)
            {
                EightBppGrayscalePalette.SetColor(i, Color.FromArgb(i, i, i));
            }

            // Assign EightBppColorPalette
            var threeBitValues = this.GetEquidistantHexValues(8);
            var twoBitValues = this.GetEquidistantHexValues(4);
            for (int i = 0; i < 256; i++)
            {
                int red = (i & 0xE0) >> 5;
                int green = (i & 0x1C) >> 2;
                int blue = i & 0x03;

                EightBppColorPalette.SetColor(i, Color.FromArgb(threeBitValues[red], threeBitValues[green], twoBitValues[blue]));
            }
        }

        public static Color Get16BitColor(ushort value)
        {
            int red = (value & 0xF800) >> 10;
            int green = (value & 0x7E0) >> 5;
            int blue = (value & 0x1F);

            return Color.FromArgb(fiveBitRange[red], sixBitRange[green], fiveBitRange[blue]);
        }

        private Dictionary<int, int> GetEquidistantHexValues(int range)
        {
            var result = new Dictionary<int, int>();
            int spaces = range - 1;
            double percentage = 100d / spaces;

            for (int i = 0; i < range; i++)
            {
                if (i == 0)
                {
                    result.Add(0, 0);
                }
                else if (i == spaces)
                {
                    result.Add(spaces, 0xFF);
                }
                else
                {
                    result.Add(i, (int)((percentage * 2.55d) * i));
                }
            }

            return result;
        }
    }
}