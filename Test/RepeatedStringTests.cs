using System;
using Xunit;
using App.problems;

namespace Test
{
    public class RepeatedStringTests
    {
        [Theory]
        [InlineData("aba", 10, 7)]
        [InlineData("a", 1000000000000, 1000000000000)]
        public void AreAnagramsTest(string s, long n, long expected)
        {
            var actual = RepeatedString.repeatedString(s, n);
            Assert.Equal(expected, actual);
        }
    }
}
