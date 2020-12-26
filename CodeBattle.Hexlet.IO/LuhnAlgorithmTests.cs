using System.Linq;
using Xunit;
using Xunit.Abstractions;
using static System.Int32;

namespace CodeBattle.Hexlet.IO
{
    public class LuhnAlgorithmTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public LuhnAlgorithmTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData("49927398716", true)]
        [InlineData("49927398717", false)]
        [InlineData("1234567812345670", true)]
        [InlineData("1234567812345678", false)]
        [InlineData("79927398710", false)]
        [InlineData("79927398711", false)]
        [InlineData("79927398712", false)]
        [InlineData("79927398713", true)]
        [InlineData("79927398714", false)]
        [InlineData("79927398715", false)]
        [InlineData("79927398716", false)]
        [InlineData("79927398717", false)]
        [InlineData("79927398718", false)]
        [InlineData("79927398719", false)]
        [InlineData("374652346956782346957823694857692364857368475368", true)]
        [InlineData("374652346956782346957823694857692364857387456834", false)]
        [InlineData("8", false)]
        [InlineData("0", true)]
        public void LuhnAlgorithmTest(string cardNumber, bool isValidExpected)
        {
            var isValid = cardNumber.Reverse().Select(c => Parse(c.ToString()))
                .Select((t, i) => i % 2 == 0
                    ? t
                    : t * 2 / 10 + t * 2 % 10)
                .Sum() % 10 == 0;
            Assert.Equal(isValidExpected, isValid);
        }
    }
}