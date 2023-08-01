using System;
using System.Collections.Generic;

public sealed class Solution_0003_LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        var lastIndexOf = new Dictionary<char, int>();
        int start = 0, length = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (lastIndexOf.ContainsKey(s[i]))
                start = Math.Max(start, lastIndexOf[s[i]] + 1);

            lastIndexOf[s[i]] = i;
            length = Math.Max(length, i - start + 1);
        }
        return length;
    }
}

