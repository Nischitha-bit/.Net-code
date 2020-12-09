using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUpTask
{
    public class PixelStatistics
    {
        internal static void PrintPixelStatistics(bool[,] image)
        {
            var logger = new Logger();
            logger.Log("");
            logger.Log($"pixels: " + GetPixelCount(image));
            logger.Log($"filled pixels: " + CountFilledPixels(image));
            logger.Log($"filled: " + Math.Round(CountFilledPixels(image) / GetPixelCount(image), 4).ToString("P"));
        }

        private static decimal CountFilledPixels(bool[,] image)
        {
            int r = 0;
            for (var i = 0; i < image.GetLength(0); i++)
            {
                for (var j = 0; j < image.GetLength(1); j++)
                {
                    r = r + (image[i, j] ? 1 : 0);
                }

            }
            return r;
        }

        private static decimal GetPixelCount(bool[,] image)
        {
            return image.GetLength(0) * image.GetLength(1);
        }
    }
}
