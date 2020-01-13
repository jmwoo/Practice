using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public class MaximumHourglassSum
    {
        public static int maximumHourglassSum(int[][] arr)
        {
            var hourglassSums = new List<int>();

            for (var i = 1; i < arr.Length - 1; i++)
            {
                for (var j = 1; j < arr[i].Length - 1; j++)
                {
                    var topLeft = arr[i - 1][j - 1];
                    var topMiddle = arr[i - 1][j];
                    var topRight = arr[i - 1][j + 1];

                    var center = arr[i][j];

                    var bottomLeft = arr[i + 1][j - 1];
                    var bottomMiddle = arr[i + 1][j];
                    var bottomRight = arr[i + 1][j + 1];

                    var hourGlass = new[] { topLeft, topMiddle, topRight, center, bottomLeft, bottomMiddle, bottomRight };
                    var hourGlassSum = hourGlass.Sum();

                    hourglassSums.Add(hourGlassSum);
                }
            }

            return hourglassSums.Max();
        }
    }
}
