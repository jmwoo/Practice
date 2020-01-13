using System;
using Xunit;
using App.problems;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    public class CompareTripletsTests
    {
        [Theory]
        [InlineData("5 6 7", "3 6 10", "1 1")]
        [InlineData("1 2 3", "4 5 6", "0 3")]
        [InlineData("2 2 2", "2 2 2", "0 0")]
        [InlineData("3 2 2", "2 3 3", "1 2")]
        public void CompareTripletsTest(string triplet1Str, string triplet2Str, string expectedStr)
        {
            var triplet1 = ConvertTripletStr(triplet1Str);
            var triplet2 = ConvertTripletStr(triplet2Str);
            var expectedTriplet = ConvertTripletStr(expectedStr);

            var actualTriplet = CompareTriplets.compareTriplets(triplet1, triplet2);

            for (int i = 0; i < expectedTriplet.Count; i++)
            {
                Assert.Equal(expectedTriplet[i], actualTriplet[i]);
            }
        }

        public List<int> ConvertTripletStr(string tripletStr)
        {
            return tripletStr.Split(' ').Select(x => Convert.ToInt32(x)).ToList();
        }
    }
}
