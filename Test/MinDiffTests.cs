using System;
using System.Linq;
using App.problems;
using Xunit;

namespace Test
{
    public class MinDiffTests
    {
        [Theory]
        [InlineData("6,10,4", 2)]
        public void MinDiffTest(string arrStr, int expected)
        {
            var intArr = arrStr.Split(",").Select(s => Convert.ToInt32(s)).ToArray();
            var actual = MinDiff.minDiff(intArr);
            Assert.Equal(expected, actual);
        }
    }
}
