using System;
using System.Linq;
using App.problems;
using Xunit;

namespace Test
{
    public class JumpingOnCloudsTests
    {
        [Theory]
        [InlineData("0 0 1 0 0 1 0", 4)]
        [InlineData("0 0 0 0 1 0", 3)]
        [InlineData("0 1 0 0 0 1 0", 3)]
        public void JumpingOnCloudsTest(string arrStr, int expected)
        {
            var arr = arrStr.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
            var result = JumpingOnClouds.jumpingOnClouds(arr);
            Assert.Equal(expected, result);
        }
    }
}
