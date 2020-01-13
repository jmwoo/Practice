using System;
using System.Collections.Generic;

namespace App.problems
{
    public class MajorityElement
    {
        // Given an array of size n, find the majority element. 
        // The majority element is the element that appears more than n/2 times.
        public static int majorityElement(int[] arr)
        {
            var length = arr.Length;
            var numTimes = length / 2;

            var d = new Dictionary<int, int>();

            foreach (var elem in arr)
            {
                if (d.ContainsKey(elem))
                {
                    d[elem] += 1;
                }
                else
                {
                    d[elem] = 1;
                }

                if (d[elem] > numTimes)
                {
                    return elem;
                }
            }

            return -1;
        }
    }
}
