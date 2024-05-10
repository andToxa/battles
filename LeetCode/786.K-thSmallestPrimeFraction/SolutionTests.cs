using FluentAssertions;
using Xunit;

namespace LeetCode._786.K_thSmallestPrimeFraction;

public class SolutionTests
{
    public static TheoryData<int[], int, int[]> TestData => new TheoryData<int[], int, int[]>()
    {
        { [1, 2, 3, 5], 3, [2, 5] },
        { [1, 7], 1, [1, 7] }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] primeNumbers, int k, int[] expectedResult)
    {
        var solution = new Solution();
        var result = solution.KthSmallestPrimeFraction(primeNumbers, k);

        result.Should().Equal(expectedResult);
    }
}