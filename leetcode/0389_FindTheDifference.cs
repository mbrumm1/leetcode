namespace leetcode;
public class Solution_0389_FindTheDifference
{
    public char FindTheDifference(string s, string t)
    {
        var letters = new int[27];

        for (int i = 0; i < s.Length; i++)
        {
            letters[s[i] - 97]++;
        }

        char difference = default;

        for (int i = 0; i < t.Length; i++)
        {
            letters[t[i] - 97]--;
            
            if (letters[t[i] - 97] == -1)
            {
                difference = t[i];
                break;
            }
        }

        return difference;
    }
}
