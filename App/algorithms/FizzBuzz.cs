using System;
using System.Collections.Generic;
using System.Linq;

namespace App.algorithms
{
    public class FizzBuzz
    {
        public static void FizzBuzzIter()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static IEnumerable<string> FizzBuzzLinq()
        {
            return Enumerable.Range(1, 100).Select(i =>
            {
                if (i % 15 == 0)
                {
                    return "FizzBuzz";
                }
                else if (i % 5 == 0)
                {
                    return "Buzz";
                }
                else if (i % 3 == 0)
                {
                    return "Fizz";
                }

                return i.ToString();

            });
        }
    }
}
