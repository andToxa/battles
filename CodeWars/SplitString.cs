using System.Collections.Generic;
using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            var result = new List<string>();
            str = str.Length % 2 == 0
                ? str
                : str + "_'";
            for (var i = 0; i < str.Length - 1; i += 2)
            {
                result.Add(str.Substring(i, 2));
            }

            return result.ToArray();
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}