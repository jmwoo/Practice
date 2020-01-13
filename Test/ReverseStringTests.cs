using System;
using App.problems;
using Xunit;

namespace Test
{
    public class ReverseStringTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abc", "cba")]
        public void ReverseStringTest(string s, string expected)
        {
            var result = ReverseString.reverseString(s);
            Assert.Equal(expected, result);
        }
    }
}
