using FluentAssertions;
using Xunit;

namespace LeetCode._0506.RelativeRanks;

public class SolutionTests
{
    public static TheoryData<int[], string[]> TestData => new()
    {
        { [5, 4, 3, 2, 1], ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"] },
        { [10, 3, 8, 9, 4], ["Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"] },
        { [1], ["Gold Medal"] },
        { [], [] },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] score, string[] expectedOutput)
    {
        var solution = new Solution();
        var output = solution.FindRelativeRanks(score);

        output.Should().Equal(expectedOutput);
    }
}