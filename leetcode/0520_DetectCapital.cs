namespace leetcode;
public sealed class Solution_0520_DetectCapital
{
    public bool DetectCapitalUse(string word)
    {
        int capitals = 0;
        bool isFirstLetterCapitalized = false;
        for (int i = 0; i < word.Length; ++i)
        {
            // A word cannot start with a lowercase letter, and have capitals after.
            if (!isFirstLetterCapitalized && capitals > 0)
            {
                return false;
            }

            if (char.IsUpper(word[i]))
            {
                capitals++;
                if (i == 0)
                {
                    isFirstLetterCapitalized = true;
                }
            }

            // Any word that contains capitals must start with one. If more than just the first letter is capitalized, then
            // the entire word should be capitalized. We can exit early if we detect that the word starts becoming lowercase after 
            // starting out with 2+ capitalized letters.
            if (isFirstLetterCapitalized && capitals > 1 && capitals < i)
            {
                return false;
            }
        }

        return (isFirstLetterCapitalized && (capitals == 1 || capitals == word.Length)) 
            || capitals == 0;
    }
}
