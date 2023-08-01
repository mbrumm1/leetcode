using System;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0350_IntersectionOfTwoArraysII
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var counter1 = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; ++i)
        {
            if (!counter1.ContainsKey(nums1[i]))
            {
                counter1.Add(nums1[i], 1);
            }
            else
            {
                ++counter1[nums1[i]];
            }
        }

        var counter2 = new Dictionary<int, int>();

        for (int i = 0; i < nums2.Length; ++i)
        {
            if (!counter2.ContainsKey(nums2[i]))
            {
                counter2.Add(nums2[i], 1);
            }
            else
            {
                ++counter2[nums2[i]];
            }
        }

        var result = new List<int>();

        foreach (var kvp in counter1)
        {
            if (counter2.ContainsKey(kvp.Key))
            {
                for (int i = 0; i < Math.Min(counter1[kvp.Key], counter2[kvp.Key]); i++)
                {
                    result.Add(kvp.Key);
                }
            }
        }

        return result.ToArray();
    }
}
