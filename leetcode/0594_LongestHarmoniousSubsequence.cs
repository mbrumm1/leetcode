using System;

namespace leetcode;
public sealed class Solution_0594_LongestHarmoniousSubsequence
{
    public int FindLHS(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        Array.Sort(nums);
        int start = 0;
        int end = 0;
        int longest = 0;

        for (int i = 1; i < nums.Length; ++i)
        {
            int difference = nums[i] - nums[start]; 

            if (difference == 1 || difference == 0)
            {
                continue;
            }
            else
            {
                start++;
            }
        }

        return 0;
    }
}
