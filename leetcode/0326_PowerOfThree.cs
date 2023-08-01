using System;

namespace leetcode;
public sealed class Solution_0326_PowerOfThree
{
    // TODO: Try without using a loop or recursion.
    public bool IsPowerOfThree(int n)
    {
        while (n > 1)
        {
            if (n % 3 != 0)
            {
                break;
            }

            n /= 3;
        }

        return n == 1;
    }
}
