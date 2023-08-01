using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0500_KeyboardRow
{
    private static HashSet<char> firstRow = new() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
    private static HashSet<char> secondRow = new() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
    private static HashSet<char> thirdRow = new() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

    public string[] FindWords(string[] words)
    {
        var ans = new List<string>();
        foreach (var word in words)
        {
            bool onFirstRow = true;
            bool onSecondRow = true;
            bool onThirdRow = true;

            for (int i = 0; i < word.Length; ++i)
            {
                char c = char.ToLower(word[i]);
                if (!firstRow.Contains(c))
                {
                    onFirstRow = false;
                }

                if (!secondRow.Contains(c))
                {
                    onSecondRow = false; 
                }

                if (!thirdRow.Contains(c))
                {
                    onThirdRow = false;
                }
            }

            if (onFirstRow || onSecondRow || onThirdRow)
            {
                ans.Add(word);
            }
        }
        return ans.ToArray();
    }
}
