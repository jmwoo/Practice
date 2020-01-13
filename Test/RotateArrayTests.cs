using System;
using Xunit;
using App.problems;
using System.Linq;

namespace Test
{
    public class RotateArrayTests
    {
        private static int[] ParseInput(string sInput) => sInput.Split(",").Select(c => int.Parse(c)).ToArray();
        private static string ConvertToOutput(int[] arr) => string.Join(",", arr.Select(i => i.ToString()));

        [Theory]
        [InlineData("1,2,3,4", "2,3,4,1")]
        public void RotateLeftTest(string sInput, string sExpected)
        {
            var inputArr = ParseInput(sInput);

            var actual = RotateArray.RotateLeft(inputArr);
            var actualStr = ConvertToOutput(actual);
            Assert.Equal(sExpected, actualStr);
        }

        [Theory]
        [InlineData("1,2,3,4", "4,1,2,3")]
        public void RotateRightTest(string sInput, string sExpected)
        {
            var inputArr = ParseInput(sInput);

            var actual = RotateArray.RotateRight(inputArr);
            var actualStr = ConvertToOutput(actual);
            Assert.Equal(sExpected, actualStr);
        }

        [Theory]
        [InlineData("1,2,3,4,5", 4, "5,1,2,3,4")]
        public void RotateLeftMultipleTimes(string sInput, int times, string sExpected)
        {
            var inputArr = ParseInput(sInput);

            var actual = RotateArray.rotLeft(inputArr, times);
            var actualStr = ConvertToOutput(actual);
            Assert.Equal(sExpected, actualStr);
        }
    }
}
