using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            // find numAs in 's'
            var numAsInS = s.Count(c => c == 'a');

            // add whole divisions of s divided by n
            var wholeDivisions = n / s.Length;

            // find remaining characters
            var remainder = n % s.Length;

            var totalAs = (wholeDivisions * numAsInS);

            var remainingAs = s.Take((int)remainder).Count(c => c == 'a');

            return totalAs + remainingAs;
        }
    }
}
