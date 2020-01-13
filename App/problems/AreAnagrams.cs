using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public static class AreAnagrams
    {
        public static bool areAnagrams(string s1, string s2)
        {
            var s1Counts = s1.ToCharacterCounts();
            var s2Counts = s2.ToCharacterCounts();

            foreach (var kvp in s1Counts)
            {
                if (!(s2Counts.ContainsKey(kvp.Key) && s2Counts[kvp.Key] == kvp.Value))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
