using System;
using System.Collections.Generic;

namespace App.problems
{
    public static class SockMerchant
    {
        public static int sockMerchant(int n, int[] ar)
        {
            var dict = new Dictionary<int, int>();
            foreach (var i in ar)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i] += 1;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            var numPairs = 0;
            foreach (var kvp in dict)
            {
                numPairs += kvp.Value / 2;
            }

            return numPairs;
        }
    }
}
