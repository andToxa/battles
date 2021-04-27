using System;
using System.Linq;
using NUnit.Framework;

namespace CodeWars
{
    public static class MorseCode
    {
        public static string Get(string s) => ".";
    }

    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            var result = string.Empty;
            var morseWords = morseCode.Trim().Split("   ");
            foreach (var morseWord in morseWords)
            {
                var letters = morseWord.Trim().Split(" ").Select(MorseCode.Get).ToArray();
                var word = string.Concat(letters);
                result = string.Concat(result, word, " ");
            }

            return result.Trim();
        }
    }

    [TestFixture]
    public class MorseCodeDecoderTests
    {
        [Test]
        public void MorseCodeDecoderBasicTest_1()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}