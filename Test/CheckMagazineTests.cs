using System;
using Xunit;
using App.problems;
using System.Linq;

namespace Test
{
    public class CheckMagazineTests
    {

        [Theory]
        [InlineData("give me one grand today night", "give one grand today", true)]
        [InlineData("two times three is not four", "two times two is four", false)]
        public void CheckMagazineTest(string magazine, string note, bool expected)
        {
            //var actual = CheckMagazine.checkMagazine(magazine.Split(' '), note.Split(' '));
            //Assert.Equal(expected, actual);

            Assert.Equal(true, false);
        }
    }
}
