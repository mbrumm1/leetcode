using System;

namespace leetcode;
public sealed class Solution_0521_LongestUncommonSubsequenceI
{
    public int FindLUSlength(string a, string b)
    {
        if (a == b)
        {
            return -1;

        }

        return Math.Max(a.Length, b.Length);
    }
}
