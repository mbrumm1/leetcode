using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0001_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2) return new[] { 0, 1 };
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
                return new int[] { map[target - nums[i]], i };
            map[nums[i]] = i;
        }
        return null;
    }
}
