using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0414_ThirdMaximumNumber
{
    public int ThirdMax(int[] nums)
    {
        int first = int.MinValue;
        int second = int.MinValue;
        int third = int.MinValue;

        var distinctValues = new HashSet<int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            if (!distinctValues.Contains(nums[i]))
            {
                distinctValues.Add(nums[i]);
            }

            if (nums[i] > first)
            {
                third = second;
                second = first;
                first = nums[i];                
            }
            else if (nums[i] > second && nums[i] != first)
            {
                third = second;
                second = nums[i];
            }
            else if (nums[i] > third && nums[i] != second && nums[i] != first)
            {
                third = nums[i];
            }
        }

        if (distinctValues.Count > 2 && third < second && second < first)
        {
            return third;
        }

        return first;
    }
}
