using System;

namespace leetcode;
public sealed class Solution_0342_PowerOfFour
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        while (n % 4 == 0)
        {
            n /= 4;
        }
        return n == 1;
    }
}
