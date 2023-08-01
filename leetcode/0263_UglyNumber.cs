using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode;
public sealed class Solution_0263_UglyNumber
{
    public bool IsUgly(int n)
    {
        if (n < 1)
        {
            return false;
        }

        n = Decompose(n, 2);
        n = Decompose(n, 3);
        n = Decompose(n, 5);

        return n == 1;
    }

    private int Decompose(int n, int factor)
    {
        while (n % factor == 0)
        {
            n /= factor;
        }
        return n;
    }
}
