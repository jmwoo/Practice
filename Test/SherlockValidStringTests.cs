using System;
using Xunit;
using App.problems;

namespace Test
{
    public class SherlockValidStringTests
    {
        [Theory]
        [InlineData("aabbcd", "NO")]
        [InlineData("aabbccddeefghi", "NO")]
        [InlineData("abcdefghhgfedecba", "YES")]
        [InlineData("aaaabbcc", "NO")]
        [InlineData("hyzzeohdidavrazjqqjfyulkoutdkywsyvrdlaitdirxkqicitijovtcpphcndwmzppmpziujzrtrcvavfjlceputwwhauvbjmnylvuuwopoqkonszzwdoqznognidorpbrazmwvaljsxzfpagmgxefktnxdqlvfoohnaflcquwnwcfwktchxhrsuqwmdtruhajkfumxplllnsjzlmjkvafqtdcywwsfycpewebnpoaegkftyoetrjjkookkmdrkhjodpstggtmpfridgoxxzijnwtziyrtfcjlrbexkxjzfcjiiafhzospmooxmhqsjzdadjzpiionnzyvzdfbtxqingfaqvuzwzcbkbqsmggziewjjbkfbcnqlsqbpmannerxghquqyvyerhpvuwywjojdhkutnkjrbizkavayqaekiwfesdaermjawgwjqfdtnefoaiosivcsrhwlmzpglbgjhctzjyuzeznehdzqybkrlhfxiwftxmceqxfcxzbczqigthyujjnusstapzvmnztfzahwaiabyjjusiqdtdznytnpukdjjyokzwhbgjehsndnxtqsyqfyjunferoqpcaqajtjtxsnlvakqrdqhipsfexjvnznrcfslzdewvujsuuilxyuhpomunyrazgsbmmplrthmnrekloxkouteiiawgryhyqjmeyxvtejjxpvkdswumqavaatgtrntkyfqycmujxdinytsspmfhmchmxpiqfdafjtenhyyedhrbcmvtyadlemzdcjujnuownulwsmbxvuyxgwshyvudktgmfcxsxnqmidlcpmakgajpwcwvzqajlixqlwkkkaysgjuvvugevrvtttovjoewzepkazwkcueiezfbvlhsdemyxctgtafsguegvatxuzhaynewanqfscephzyabduhzyqualuukbxlodhrqzwieaalcynddhnefdyfqsbawalmdudwuagycglegyklfxpmcq", "NO")]
        public void SherlockValidStringTest(string s, string expected)
        {
            var result = SherlockValidString.isValid(s);
            Assert.Equal(expected, result);
        }
    }
}
