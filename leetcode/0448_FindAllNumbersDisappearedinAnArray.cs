using System;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0448_FindAllNumbersDisappearedinAnArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int indexToMark = Math.Abs(nums[i]) - 1;
            nums[indexToMark] = -Math.Abs(nums[indexToMark]);
        }

        var disappearedNumbers = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                disappearedNumbers.Add(i + 1);
            }
        }
        return disappearedNumbers;
    }
}
