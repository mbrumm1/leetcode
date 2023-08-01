using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode;
public sealed class Solution_0482_LicenseKeyFormatting
{
    public string LicenseKeyFormatting(string s, int k)
    {
        int count = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] != '-')
            {
                count++;
            }
        }

        if (count == 0)
        {
            return string.Empty;
        }

        int dashes = count / k + (count % k == 0 ? -1 : 0);
        var reformatted = new char[count + dashes];
        int index = reformatted.Length - 1;
        int dashTracker = 1;

        for (int i = s.Length - 1; i >= 0; --i)
        {
            if (s[i] == '-')
            {
                continue;
            }

            if (dashTracker > k)
            {
                reformatted[index] = '-';
                dashTracker = 1;
                index--;
            }

            if (s[i] >= 97 && s[i] <= 122)
            {
                reformatted[index] = (char)(s[i] - 32);
            }
            else
            {
                reformatted[index] = s[i];
            }

            dashTracker++;
            index--;
        }

        return new string(reformatted);
    }
}
