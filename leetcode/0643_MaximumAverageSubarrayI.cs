using System;

namespace leetcode;
public sealed class Solution_0643_MaximumAverageSubarrayI
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int start = 0;
        int end = k - 1;

        double maxAverage = double.MinValue;
        double sum = 0;

        while (end < nums.Length)
        {
            if (start == 0)
            {
                for (int i = start; i <= end; ++i)
                {
                    sum += nums[i];
                }
            }
            else
            {
                sum -= nums[start - 1];
                sum += nums[end];
            }

            maxAverage = Math.Max(maxAverage, sum / k);
            start++;
            end++;
        }

        return maxAverage;
    }
}
