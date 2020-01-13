using System;
using Xunit;
using App.problems;

namespace Test
{
    public class AreAnagramsTests
    {
        [Theory]
        [InlineData("abc", "cba", true)]
        [InlineData("abcdefghijklm", "malbkcjdiehfg", true)]
        [InlineData("abcd", "abc", false)]
        public void AreAnagramsTest(string s1, string s2, bool expected)
        {
            var areAnagrams = AreAnagrams.areAnagrams(s1, s2);
            Assert.Equal(areAnagrams, expected);
        }
    }
}
