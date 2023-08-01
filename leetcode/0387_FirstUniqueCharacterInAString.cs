using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0387_FirstUniqueCharacterInAString
{
    public int FirstUniqChar(string s)
    {
        if (s.Length == 1)
        {
            return 0;
        }

        var counts = new Dictionary<char, int>();

        for (int i  = 0; i < s.Length; i++)
        {
            if (!counts.ContainsKey(s[i]))
            {
                counts.Add(s[i], 1);
            }
            else
            {
                counts[s[i]]++;
            }
        }

        char? firstUniqueChar = null;
        foreach (var kvp in counts)
        {
            if (kvp.Value == 1)
            {
                firstUniqueChar = kvp.Key;
                break;
            }
        }

        if (!firstUniqueChar.HasValue)
        {
            return -1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == firstUniqueChar)
            {
                return i;
            }
        }

        return -1;
    }
}
