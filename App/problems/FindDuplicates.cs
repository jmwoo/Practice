using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public class FindDuplicates
    {
        public static IDictionary<char, int> findDuplicates(string s)
        {
            return s.ToCharacterCounts()
                .Where(kv => kv.Value > 1)
                .ToDictionary(kv => kv.Key, kv => kv.Value);
        }
    }
}
