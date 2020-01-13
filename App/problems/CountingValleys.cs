using System;
namespace App.problems
{
    public static class CountingValleys
    {
        public static int countingValleys(int n, string s)
        {
            var current = 0;
            int? prev = null;

            var totalValleys = 0;
            foreach (var step in s.ToCharArray())
            {
                prev = current;

                var next = step == 'U' ? 1 : -1;

                current = current + next;

                if (current == 0 && prev == -1)
                {
                    totalValleys += 1;
                }
            }

            return totalValleys;
        }
    }
}
