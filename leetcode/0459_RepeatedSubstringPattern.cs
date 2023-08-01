using System.Collections;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0459_RepeatedSubstringPattern
{
    public bool RepeatedSubstringPattern(string s)
    {
        if (s.Length == 1)
        {
            return false;
        }

        int divisor = 2;        

        while (divisor <= s.Length)
        {
            if (s.Length % divisor == 0)
            {
                int quotient = s.Length / divisor;
                string subString = s.Substring(0, quotient);
                string compare = "";

                for (int i = 0; i < divisor; i++)
                {
                    compare += subString;
                }

                if (compare == s)
                {
                    return true;
                }
            }

            ++divisor;
        }

        return false;
    }

    public bool RepeatedSubstringPattern2(string s)
    {
        if (s.Length == 1)
        {
            return false;
        }
       
        foreach (var substringLength in SubstringLengths(s.Length))
        {
            bool hasRepeatedSubstring = true;
            int pieces = s.Length / substringLength;

            for (int i = 0; i < pieces; ++i)
            {
                for (int j = 0; j < substringLength; ++j)
                {
                    if (s[i * substringLength + j] != s[j])
                    {
                        hasRepeatedSubstring = false;
                        break;
                    }
                }

                if (!hasRepeatedSubstring)
                {
                    break;
                }
            }

            if (hasRepeatedSubstring)
            {
                return true;
            }
        }

        return false;
    }

    private IEnumerable<int> SubstringLengths(int length)
    {
        for (int i = length / 2; i >= 1; --i)
        {
            if (length % i == 0)
            {
                yield return i;
            }
        }
    }
}
