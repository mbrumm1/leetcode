namespace leetcode;
public sealed class Solution_0006_ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        var ans = new char[s.Length];
        int i = 0;
        for (int row = 1; row <= numRows; ++row)
        {
            int j = row - 1;
            while (j < s.Length && i < s.Length)
            {
                ans[i] = s[j];
                int position = j % (numRows - 1) + 1;
                j += (numRows - position) * 2;
                i++;
            }
        }
        return new string(ans);
    }
}
