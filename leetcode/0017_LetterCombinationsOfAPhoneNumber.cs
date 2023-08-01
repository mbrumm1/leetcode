using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0017_LetterCombinationsOfAPhoneNumber
{
    private static Dictionary<char, string> mapping = new()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    private List<string> ans = new();

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return ans;
        }

        FindCombinations(digits, 0, new char[digits.Length]);
        return ans;
    }

    private void FindCombinations(string digits, int index, char[] combination)
    {
        if (index >= digits.Length)
        {
            ans.Add(new string(combination));
            return;
        }

        string letters = mapping[digits[index]];

        foreach (char letter in letters)
        {
            combination[index] = letter;
            FindCombinations(digits, index + 1, combination);
        }
    }
}
