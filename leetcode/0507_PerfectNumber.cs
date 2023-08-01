using System;

namespace leetcode;
public sealed class Solution_0507_PerfectNumber
{
    public bool CheckPerfectNumber(int num)
    {
        if (num == 1)
        {
            return false;
        }

        int divisorSum = 0;
        for (int i = 2; i <= Math.Sqrt(num); ++i)
        {
            if (num % i == 0)
            {
                divisorSum += i + num / i;
            }
        }
        divisorSum++;
        return divisorSum == num;
    }
}
