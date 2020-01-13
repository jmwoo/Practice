using System;
using System.Linq;

namespace App.problems
{
    public class MinDiff
    {
        public static int minDiff(int[] arr)
        {
            var sorted = arr.OrderBy(x => x).ToList();
            int? minDiff = null;
            for (var i = 0; i < sorted.Count - 1; i++)
            {
                var currentDiff = sorted[i + 1] - sorted[i];
                minDiff = !minDiff.HasValue ? currentDiff : Math.Min(minDiff.Value, currentDiff);
            }
            return minDiff.Value;
        }
    }
}
