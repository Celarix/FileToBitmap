using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileToBitmap
{
    public static class NumericExtensions
    {
        public static void Times(this int iterations, Action<int> action)
        {
            for (int i = 0; i < iterations; i++)
            {
                action(i);
            }
        }

        public static bool IsPerfectSquare(this int i)
        {
            if (i <= 1) return false;

            int squareRoot = (int)Math.Sqrt(i);
            return (squareRoot * squareRoot) == i;
        }

        public static List<int> GetFactors(this int value)
        {
            var result = new List<int>();

            if (value <= 1) return result;

            for (int i = 1; i <= value / 2; i++)
            {
                if (value % i == 0) result.Add(i);
            }

            result.Add(value);
            return result;
        }

        public static string GetFileSizeString(this long length)
        {
            char[] prefixes = new char[] { 'K', 'M', 'G', 'T', 'P', 'E', 'Z', 'Y' };
            int prefixIndex = -1;
            decimal lengthValue = length;

            while (lengthValue > 1024m)
            {
                lengthValue /= 1024m;
                if (prefixIndex != -1 && prefixes[prefixIndex] == 'Y')
                {
                    return string.Format("{0} YB", lengthValue);
                }
                else
                {
                    prefixIndex++;
                }
            }

            if (prefixIndex == -1)
            {
                return string.Format("{0} bytes", length);
            }
            else
            {
                return string.Format("{0} {1}B", Decimal.Round(lengthValue, 2), prefixes[prefixIndex]);
            }
        }
    }
}
