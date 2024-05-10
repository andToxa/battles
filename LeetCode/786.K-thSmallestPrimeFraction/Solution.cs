using System.Collections.Generic;
using System.Linq;

namespace LeetCode._786.K_thSmallestPrimeFraction;

public class Solution
{
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var fractions = new SortedDictionary<double, (int, int)>();
        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                fractions.Add((double)arr[i] / arr[j], (arr[i], arr[j]));
            }
        }

        return new[] { fractions.ElementAt(k - 1).Value.Item1, fractions.ElementAt(k - 1).Value.Item2 };
    }
}