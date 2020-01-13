using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public static class MakeAnagram
    {
        public static int makeAnagram(string a, string b)
        {
            var aCharCounts = a.GroupBy(c => c)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Count());
            var bCharCounts = b.GroupBy(c => c)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Count());

            var longerCounts = aCharCounts.Count > bCharCounts.Count ? aCharCounts : bCharCounts;
            var shorterCounts = new[] { aCharCounts, bCharCounts }.FirstOrDefault(x => x.GetHashCode() != longerCounts.GetHashCode());

            var alreadyAccountedForChars = new List<char>();
            var deletions = 0;
            foreach (var kvp in longerCounts)
            {
                var numCounts = kvp.Value;
                if (shorterCounts.ContainsKey(kvp.Key))
                {
                    deletions += Math.Abs(kvp.Value - shorterCounts[kvp.Key]);
                }
                else
                {
                    deletions += kvp.Value;
                }
                alreadyAccountedForChars.Add(kvp.Key);
            }

            foreach (var kvp in shorterCounts.Where(k => !alreadyAccountedForChars.Contains(k.Key)))
            {
                deletions += kvp.Value;
            }

            return deletions;
        }
    }
}
