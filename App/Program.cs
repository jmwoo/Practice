using System;
using System.Collections.Generic;
using System.Linq;
using App.algorithms;
using App.DataStructures;
using App.problems;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray =
            {
                new int[] { 1, 1, 1, 0, 0, 0, },
                new int[] { 0, 1, 0, 0, 0, 0, },
                new int[] { 1, 1, 1, 0, 0, 0, },
                new int[] { 0, 0, 2, 4, 4, 0, },
                new int[] { 0, 0, 0, 2, 0, 0, },
                new int[] { 0, 0, 1, 2, 4, 0, },
            };

            var maximumHourglassSum = MaximumHourglassSum.maximumHourglassSum(jaggedArray);
        }
    }
}
