using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode;
public sealed class Solution_0504_Base7
{
    public string ConvertToBase7(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        bool isNegative = num < 0;
        num = Math.Abs(num);
        var stack = new Stack<int>();
        while (num != 0)
        {
            int remainder = num % 7;
            num /= 7;

            if (num == 0 && isNegative)
            {
                remainder = -remainder;
            }
            stack.Push(remainder);
        }

        return string.Join("", stack);
    }
}
