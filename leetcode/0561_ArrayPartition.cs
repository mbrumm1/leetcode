using System;

namespace leetcode;
public sealed class Solution_0561_ArrayPartition
{
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        int sum = 0;
        for(int i = 0; i < nums.Length; i += 2)
        {
            sum += Math.Min(nums[i], nums[i + 1]);
        }
        return sum;
    }
}
