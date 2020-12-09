using System;

namespace CleanUpTask
{
    public class ConsoleApplication
    {
        public void Run(string[] args)
        {
            var logger = new Logger();
            logger.Log("Count active pixels in imageX or imageY? press x or y and enter");

            var key = Console.ReadLine();
            while (!(key == "x" || key == "y")){
                logger.Log("invalid key. press x or y and enter");
                key = Console.ReadLine();
            }

            ProcessVisionFile(key);           
        }

        private void ProcessVisionFile(string key)
        {
            bool[,] visionFile = new bool[,] { };
            switch(key.ToLower())
            {
                case "x":
                    visionFile = VisionFiles.imageX;
                    break;
                case "y":
                    visionFile = VisionFiles.imageY;
                    break;
                default:
                    break;
            }

            VisionFilePrint.PrintImage(visionFile);
            PixelStatistics.PrintPixelStatistics(visionFile);
        }
    }
}
