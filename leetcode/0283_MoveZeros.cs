using System;

namespace leetcode;
public sealed class Solution_0283_MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        if (nums.Length == 1)
        {
            return;
        }

        int i = 0, j = 1;
        while (j < nums.Length)
        {
            if (nums[i] == 0 && nums[j] != 0)
            {
                nums[i++] = nums[j];
                nums[j] = 0;
            }

            if (nums[i] != 0)
            {
                ++i;
            }

            ++j;
        }
    }
}
