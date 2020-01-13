using System;
using System.Linq;

namespace App.problems
{
    public class RotateArray
    {
        public static int[] RotateLeft(int[] arr)
        {
            if (arr == null || arr.Length == 0 || arr.Length == 1)
            {
                return arr;
            }

            var first = arr[0];

            for (var i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = first;

            return arr;
        }

        public static int[] RotateRight(int[] arr)
        {
            if (arr == null || arr.Length == 0 || arr.Length == 1)
            {
                return arr;
            }

            var last = arr[arr.Length - 1];

            for (var i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;

            return arr;
        }

        public static int[] rotLeft(int[] arr, int d)
        {
            var wholeDivisions = d / arr.Length;
            var remainder = d % arr.Length;

            var timesToRotateLeft = remainder;
            var timesToRotateRight = arr.Length - remainder;

            if (timesToRotateLeft < timesToRotateRight)
            {
                for (var i = 0; i < timesToRotateLeft; i++)
                {
                    arr = RotateLeft(arr);
                }
            }
            else
            {
                for (var i = 0; i < timesToRotateRight; i++)
                {
                    arr = RotateRight(arr);
                }
            }

            return arr;
        }
    }
}
