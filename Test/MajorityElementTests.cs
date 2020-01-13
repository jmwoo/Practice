using System;
using System.Linq;
using App.problems;
using Xunit;

namespace Test
{
    public class MajorityElementTests
    {
        [Theory]
        [InlineData("3,2,3", 3)]
        [InlineData("2,2,1,1,1,2,2", 2)]
        public void MajorityElementTest(string arrStr, int expected)
        {
            var arr = arrStr.Split(",").Select(x => Convert.ToInt32(x)).ToArray();
            var result = MajorityElement.majorityElement(arr);
            Assert.Equal(expected, result);
        }
    }
}
