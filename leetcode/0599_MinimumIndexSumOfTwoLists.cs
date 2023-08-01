using System;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0599_MinimumIndexSumOfTwoLists
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var counter1 = new Dictionary<string, int>();
        for (int i = 0; i < list1.Length; ++i)
        {
            counter1.Add(list1[i], i);
        }

        var counter2 = new Dictionary<string, int>();
        for (int i = 0; i < list2.Length; ++i)
        {
            counter2.Add(list2[i], i);
        }

        int leastIndexSum = list1.Length + list2.Length - 1;
        foreach (var kvp in counter1)
        {
            if (counter2.ContainsKey(kvp.Key))
            {
                int sum = kvp.Value + counter2[kvp.Key];
                leastIndexSum = Math.Min(sum, leastIndexSum);
                counter1[kvp.Key] = sum;
            }
            else
            {
                counter1[kvp.Key] = -kvp.Value;
            }
        }

        var answer = new List<string>();
        foreach (var kvp in counter1)
        {
            if (kvp.Value < 0 || kvp.Value != leastIndexSum)
            {
                continue;
            }

            answer.Add(kvp.Key);
        }
        return answer.ToArray();
    }
}
