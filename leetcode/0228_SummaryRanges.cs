using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0228_SummaryRanges
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var ranges = new List<string>();

        if (nums is null || nums.Length == 0)
        {
            return ranges;
        }

        int start = 0;
        int end = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 < nums.Length && nums[i + 1] - nums[i] == 1)
            {
                end++;
            }
            else
            {
                if (start == end)
                {
                    ranges.Add(nums[start].ToString());
                }
                else
                {
                    ranges.Add($"{nums[start]}->{nums[end]}");
                }

                start = end = i + 1;
            }
        }

        return ranges;
    }
}
