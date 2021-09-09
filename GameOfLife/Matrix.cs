using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    // In this matrix save dead or life call info
    static class Matrix
    {
        public static float[,] arr;
        static Matrix()
        {
            arr = new float[Game.x, Game.y];
        }
    }
}
