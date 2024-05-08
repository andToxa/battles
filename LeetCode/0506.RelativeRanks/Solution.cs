using System;
using System.Linq;

namespace LeetCode._0506.RelativeRanks;

public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        var answer = new string[score.Length];

        for (var i = 1; i <= score.Length; i++)
        {
            var maxValue = score.Max();
            var maxIndex = Array.IndexOf(score, maxValue);
            score[maxIndex] = -1;
            answer[maxIndex] = i switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => i.ToString()
            };
        }
        
        return answer;
    }
}