using System;
using Xunit;
using App.problems;

namespace Test
{
    public class AlternatingCharactersTests
    {
        [Theory]
        [InlineData("aabbcd", "NO")]
        [InlineData("aabbccddeefghi", "NO")]
        [InlineData("abcdefghhgfedecba", "YES")]
        public void SherlockValidStringTest(string s, string expected)
        {
            var result = SherlockValidString.isValid(s);
            Assert.Equal(expected, result);
        }
    }
}
