using System;
using Xunit;
using App.problems;

namespace Test
{
    public class MakeAnagramTests
    {
        [Theory]
        [InlineData("cde", "abc", 4)]
        [InlineData("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke", 30)]
        public void MakeAnagramTest(string a, string b, int expected)
        {
            var result = MakeAnagram.makeAnagram(a, b);
            Assert.Equal(expected, result);
        }
    }
}
