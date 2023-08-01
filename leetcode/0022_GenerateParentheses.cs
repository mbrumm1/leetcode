using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0022_GenerateParentheses
{
    public IList<string> GenerateParentheses(int n)
    {
        var ans = new List<string>();
        Backtrack(n, new char[2 * n], 0, ans, 0, 0);
        return ans;
    }

    private void Backtrack(int n, char[] comb, int curr, List<string> ans, int open, int close)
    {
        if (curr == 2 * n)
        {
            ans.Add(new string(comb));
            return;
        }

        if (open < n)
        {
            comb[curr] = '(';
            Backtrack(n, comb, curr + 1, ans, open + 1, close);
        }

        if (close < open)
        {
            comb[curr] = ')';
            Backtrack(n, comb, curr + 1, ans, open, close + 1);
        }
    }
}
