using System;
using System.Linq;

namespace App.problems
{
    public static class ArrayOfInts
    {
        public static int arrayOfInts(int[] arr)
        {
            return arr
               .Where(x => x % 2 == 0)
               .Sum();
        }
    }
}
