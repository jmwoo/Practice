using System;
namespace App.problems
{
    public static class AlternatingCharacters
    {
        public static int alternatingCharacters(string s)
        {
            var arr = s.ToCharArray();

            char? prev = null;
            var drops = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var c = arr[i];

                if (prev != null)
                {
                    if (prev == c)
                    {
                        drops += 1;
                    }
                }

                prev = c;
            }

            return drops;
        }
    }
}
