using System;

namespace leetcode;
public sealed class Solution_0011_ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int start = 0;
        int end = height.Length - 1;
        int max = 0;

        while (start < end)
        {
            int h = Math.Min(height[start], height[end]);
            int w = end - start;
            max = Math.Max(max, h * w);

            if (height[start] < height[end])
            {
                start++;
            }
            else if (height[start] > height[end])
            {
                end--;
            }
            else
            {
                start++;
                end--;
            }
        }

        return max;
    }
}
