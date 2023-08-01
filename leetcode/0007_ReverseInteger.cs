using System;
using System.Linq;

namespace leetcode;
public sealed class Solution_0007_ReverseInteger
{
    public int Reverse(int x)
    {
        var reversed = Convert.ToString(x).Reverse().ToList();
        if (x < 0)
        {
            reversed.Insert(0, '-');
            reversed.RemoveAt(reversed.Count - 1);
        }
        return int.TryParse(String.Concat(reversed), out int result) ? result : 0;
    }
}
