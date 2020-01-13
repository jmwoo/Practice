using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public static class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var aScore = 0;
            var bScore = 0;
            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aScore += 1;
                }
                else if (a[i] < b[i])
                {
                    bScore += 1;
                }
            }
            return new[] { aScore, bScore }.ToList();
        }
    }
}
