using System;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0575_DistributeCandies
{
    public int DistributeCandies(int[] candyType)
    {
        var set = new HashSet<int>();
        for (int i = 0; i < candyType.Length; ++i)
        {
            if (!set.Contains(candyType[i]))
            {
                set.Add(candyType[i]);
            }
        }
        return Math.Min(set.Count, candyType.Length / 2);
    }
}
