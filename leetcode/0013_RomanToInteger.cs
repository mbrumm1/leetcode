using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class Solution_0013_RomanToInteger
    {
        private static Dictionary<char, char[]> subtractionMap = new Dictionary<char, char[]>
        {
            { 'I', new char[] { 'V', 'X' } },
            { 'X', new char[] { 'L', 'C' } },
            { 'C', new char[] { 'D', 'M' } }
        };

        public int RomanToInt(string s)
        {
            int i = 0;
            int sum = 0;
            while (i < s.Length)
            {
                int value = s[i] switch
                {
                    'I' => 1,
                    'V' => 5,
                    'X' => 10,
                    'L' => 50,
                    'C' => 100,
                    'D' => 500,
                    'M' => 1000,
                    _ => 0
                };

                if (i + 1 < s.Length && subtractionMap.ContainsKey(s[i]))
                {
                    char nextNumeral = s[i + 1];
                    if (subtractionMap[s[i]].Any(x => x == nextNumeral))
                        value *= -1;
                }
                sum += value;
                i++;
            }
            return sum;
        }
    }
}
