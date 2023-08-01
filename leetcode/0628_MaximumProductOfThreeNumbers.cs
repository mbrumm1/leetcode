using System;

namespace leetcode;
public sealed class Solution_0628_MaximumProductOfThreeNumbers
{
    public int MaximumProduct(int[] nums)
    {
        if (nums.Length == 3)
        {
            return nums[0] * nums[1] * nums[2];
        }

        Array.Sort(nums);

        return Math.Max(
            nums[0] * nums[1] * nums[^1],
            nums[^1] * nums[^2] * nums[^3]);
    }
}
