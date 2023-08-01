using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0349_IntersectionOfTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var visited = new Dictionary<int, int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!visited.ContainsKey(nums1[i]))
            {
                visited[nums1[i]] = 1;
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (visited.ContainsKey(nums2[i]))
            {
                visited[nums2[i]] = 2;
            }
        }

        var intersection = new List<int>();
        foreach (var pair in visited)
        {
            if (pair.Value == 2)
            {
                intersection.Add(pair.Key);
            }
        }
        return intersection.ToArray();
    }
}
