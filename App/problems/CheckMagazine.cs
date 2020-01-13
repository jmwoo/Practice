using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
    public class CheckMagazine
    {
        public static IDictionary<string, int> ToWordCounts(string[] arr)
        {
            var d = new Dictionary<string, int>();

            foreach (var word in arr)
            {
                if (d.ContainsKey(word))
                {
                    d[word] += 1;
                }
                else
                {
                    d[word] = 1;
                }
            }

            return d;
        }

        public static bool checkMagazineResult(string[] magazine, string[] note)
        {
            var noteD = ToWordCounts(note);
            var magD = ToWordCounts(magazine);

            foreach (var word in noteD.Keys)
            {
                if (!magD.ContainsKey(word) || magD[word] < noteD[word])
                {
                    return false;
                }
            }

            return true;
        }

        static void checkMagazine(string[] magazine, string[] note)
        {
            var result = checkMagazineResult(magazine, note);
            Console.WriteLine(result ? "Yes" : "No");

        }
    }
}
