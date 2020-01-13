using System;
using Xunit;
using App.problems;
using App;
using System.Linq;

namespace Test
{
    public class ToCharacterCountsTests
    {
        [Theory]
        [InlineData("aaaabbcc", "a:4,b:2,c:2")]
        [InlineData("a", "a:1")]
        [InlineData("", "")]
        [InlineData("aA", "a:1,A:1")]
        public void ToCharacterCountsTest(string s, string expectedStr)
        {
            var result = s.ToCharacterCounts();
            var resultStr = string.Join(",", result.Select(kvp => $"{kvp.Key}:{kvp.Value}"));
            Assert.Equal(expectedStr, resultStr);
        }
    }
}
