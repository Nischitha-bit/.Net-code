using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUpTask
{
    public class VisionFiles
    {
        public static bool[,] imageX = new bool[,] {
            { true, false, false, false, true },
            { true, false, false, false, true },
            { false, true, false, true, false },
            { false, false, true, false, false },
            { false, true, false, true, false },
            { true, false, false, false, true },
            { true, false, false, false, true },
        };

        public static bool[,] imageY = new bool[,] {
            { true, false, false, false, true },
            { true, false, false, false, true },
            { false, true, false, true, false },
            { false, false, true, false, false },
            { false, false, true, false, false },
            { false, false, true, false, false },
            { false, false, true, false, false },
        };
    }
}
