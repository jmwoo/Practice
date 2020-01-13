using System;
namespace App.problems
{
    public class ReverseString
    {
        public static string reverseString(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }

            var arr = s.ToCharArray();

            for (var i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            return new string(arr);
        }
    }
}
