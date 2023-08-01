namespace leetcode;
public sealed class Solution_0557_ReverseWordsInAStringIII
{
    public string ReverseWords(string s)
    {
        if (s.Length == 1)
        {
            return s;
        }

        var answer = s.ToCharArray();
        int left = 0;
        for (int i = 0; i <= s.Length; ++i)
        {
            if (i == s.Length || s[i] == ' ')
            {
                int right = i - 1;
                while (left < right)
                {
                    answer[left] = s[right];
                    answer[right] = s[left];
                    left++;
                    right--;
                }
                left = i + 1;
            }
        }

        return new string(answer);
    }
}
