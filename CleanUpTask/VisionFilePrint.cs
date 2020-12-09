using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUpTask
{
    public class VisionFilePrint
    {
        internal static void PrintImage(bool[,] image)
        {
            var logger = new Logger();
            logger.Log("");
            for (var i = 0; i < image.GetLength(0); i++)
            {
                for (var j = 0; j < image.GetLength(1); j++)
                {
                    logger.Write(image[i, j] ? "#" : " ");
                }
                logger.Write(System.Environment.NewLine);
            }
        }
    }
}
