namespace leetcode;
public sealed class Solution_0383_RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteCounts = GetLetterCounts(ransomNote);
        var magazineCounts = GetLetterCounts(magazine);

        for (int i = 0; i < ransomNoteCounts.Length; i++) 
        {
            // If the ransom string has a higher count of certain letter then it could not have been made from the magazine.
            if (ransomNoteCounts[i] > magazineCounts[i])
            {
                return false;
            }
        }

        return true;
    }

    private int[] GetLetterCounts(string s)
    {
        // Create an array where each index represents a lowercase letter in the alphabet.
        var counts = new int[27];

        for (int i = 0; i < s.Length; i++)
        {
            // A lower case 'a' (the start) has a decimal value of 97 in ASCII and Unicode, so
            // we subtract 97 to fit between 0 and 26.
            counts[s[i] - 97]++;
        }

        return counts;
    }
}
