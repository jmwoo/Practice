using System;
using System.Collections.Generic;

namespace App.problems
{
    public static class JumpingOnClouds
    {
        public static int jumpingOnClouds(int[] c)
        {
            var totalJumps = 0;
            const int jump2 = 2;
            const int jump1 = 1;
            var currentPosition = 0;

            while (true)
            {
                // try to jump 2
                if (currentPosition < c.Length - jump2 && c[currentPosition + jump2] == 0)
                {
                    currentPosition += jump2;
                }
                // just jump 1
                else if (currentPosition < c.Length - jump1 && c[currentPosition + jump1] == 0)
                {
                    currentPosition += jump1;
                }
                totalJumps += 1;

                if (currentPosition == c.Length - 1)
                {
                    break;
                }
            }

            return totalJumps;
        }
    }
}
