using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode;
public sealed class Solution_0202_HappyNumber
{
    public bool IsHappy(int n)
    {
        // Keep track of every sum, so that we detect if we're in an endless loop.
        var visitedNumbers = new HashSet<double>();
        // Declare sum outside the loop, so that there's only one value we're working with.
        // Both the sum and hashset are of type double because that's what Math.Pow returns.
        double sum = 0;
        bool isHappy = false;

        // Loop on the number and go through its digits.
        while (n > 0)
        {
            int digit = n % 10;
            n /= 10;
            sum += Math.Pow(digit, 2);

            // If this is the last digit from the current working number, then we have to make a decision.
            if (n == 0)
            {
                if (sum == 1)
                {
                    isHappy = true;
                    break;
                }

                if (visitedNumbers.Contains(sum))
                {
                    isHappy = false;
                    break;
                }

                // Determination couldn't be made, n is now the new sum.
                // Keep track of sum in set, and then reset the working sum.
                visitedNumbers.Add(sum);
                n = (int)sum;
                sum = 0;
            }
        }

        return isHappy;
    }
}
