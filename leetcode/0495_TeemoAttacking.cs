using System;

namespace leetcode;
public sealed class Solution_0495_TeemoAttacking
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int total = 0;
        for (int i = 1; i < timeSeries.Length; ++i)
        {
            total += Math.Min(timeSeries[i] - timeSeries[i - 1], duration);
        }
        return total += duration;
    }
}
