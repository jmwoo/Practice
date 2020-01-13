using System;
using System.Linq;
using App.problems;
using Xunit;

namespace Test
{
    public class MaximumHourglassSumTests
    {
        [Fact]
        public void MaximumHourglassSumTest1()
        {
            int[][] jaggedArray =
            {
                new int[] { 1, 1, 1, 0, 0, 0, },
                new int[] { 0, 1, 0, 0, 0, 0, },
                new int[] { 1, 1, 1, 0, 0, 0, },
                new int[] { 0, 0, 2, 4, 4, 0, },
                new int[] { 0, 0, 0, 2, 0, 0, },
                new int[] { 0, 0, 1, 2, 4, 0, },
            };

            const int expected = 19;

            var actual = MaximumHourglassSum.maximumHourglassSum(jaggedArray);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaximumHourglassSumTest2()
        {
            int[][] jaggedArray =
            {
                new int[] { -9, -9, -9, 1, 1, 1 },
                new int[] { 0, -9,  0, 4, 3, 2 },
                new int[] { -9, -9, -9, 1, 2, 3 },
                new int[] { 0,  0,  8, 6, 6, 0 },
                new int[] { 0,  0,  0, -2, 0, 0 },
                new int[] { 0,  0,  1, 2, 4, 0 },
            };

            const int expected = 28;

            var actual = MaximumHourglassSum.maximumHourglassSum(jaggedArray);

            Assert.Equal(expected, actual);
        }
    }
}
