using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public static class SherlockValidString
    {
        public static string isValid(string s)
        {
            const string yes = "YES";
            const string no = "NO";

            var d = s.ToCharacterCounts();
            var counts = d.Values.ToList().OrderByDescending(x => x).ToList();
            var first = counts.First();
            var last = counts.Last();
            var length = counts.Count();

            if (first == last)
            {
                return yes;
            }

            if (Math.Abs(first - last) != 1)
            {
                return no;
            }

            var firstCounts = counts.Count(c => c == first);
            var lastCounts = counts.Count(c => c == last);

            if (
                (firstCounts == 1 && lastCounts == length - 1)
                || (lastCounts == 1 && firstCounts == length - 1)
            )
            {
                return yes;
            }

            return no;
        }


        public static string isValid2(string s)
        {
            var d = s.ToCharacterCounts();
            var counts = d.Values.ToList().OrderByDescending(x => x).ToList();
            var first = counts.First();

            if (counts.All(c => c == first))
            {
                return "YES";
            }

            var next = counts.FirstOrDefault(c => c != first);

            if (counts.Count(c => c == next) == 1 && counts.Distinct().Count() == 2)
            {
                return "YES";
            }

            return "NO";
        }
    }
}
