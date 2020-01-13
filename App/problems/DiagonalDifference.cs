using System;
using System.Collections.Generic;
using System.Linq;

namespace App.problems
{
  public class DiagonalDifference
  {
    /*
      11 2 4
      4 5 6
      10 8 -12
    */

    // 15

    public static int diagonalDifference(List<List<int>> arr)
    {
        var len = arr.FirstOrDefault().Count;
        var first = 0;
        var last = len - 1;

        var ltrDiag = new List<int>();
        var rtlDiag = new List<int>();

        foreach (var list in arr)
        {
            ltrDiag.Add(list[first]);
            rtlDiag.Add(list[last]);
            first++;
            last--;
        }

        var ltrDiagSum = ltrDiag.Sum();
        var rtlDiagSum = rtlDiag.Sum();

        var diff = Math.Abs(rtlDiagSum - ltrDiagSum);

        return diff;
    }
  }
}