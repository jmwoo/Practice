using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public static class Util
    {
        public static IDictionary<char, int> ToCharacterCounts(this string s)
        {
            return s
                .GroupBy(c => c)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Count());
        }
    }
}
