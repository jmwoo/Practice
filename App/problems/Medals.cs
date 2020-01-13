using System;
using System.Collections.Generic;

namespace App.problems
{
    public static class Medals
    {
        /*
            Input: [5, 4, 3, 2, 1]
            Output: ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
            Explanation: The first three athletes got the top three highest scores,
            so they got "Gold Medal", "Silver Medal" and "Bronze Medal". 
            For the left two athletes, you just need to output their relative ranks
            according to their scores.
        */

        /*
            [5, 4, 3, 2, 1]
            ["0", "1", "2", "3", "4"]
        */

        public static string[] medals(int[] arr)
        {
            //string[] scores = new string[arr.Length];

            //var sortedSet = new SortedSet<int>(arr);
            //var sortedDictionary = new SortedDictionary<int, int>();

            var sortedDictionary = new SortedDictionary<int, int>();
            var outArr = new string[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                sortedDictionary.Add(arr[i], i);
            }

            //fo

            //var d = new Dictionary<int, string>();
            //foreach (var numMedals in arr)
            //{
            //}



            //Sorted

            throw new NotImplementedException();
        }
    }
}
