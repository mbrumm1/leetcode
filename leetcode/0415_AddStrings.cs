using System;

namespace leetcode;
public sealed class Solution_0415_AddStrings
{
    private const string zero = "0";

    public string AddStrings(string num1, string num2)
    {
        if (num1 == zero && num2 == zero)
        {
            return zero;
        }

        if (num1 == zero)
        {
            return num2;
        }

        if (num2 == zero)
        {
            return num1;
        }

        var i = num1.Length - 1;
        var j = num2.Length - 1;
        var carry = 0;
        var maxLength = Math.Max(num1.Length, num2.Length);
        var result = new char[maxLength + 1];
        var k = result.Length - 1;

        while (i >= 0 || j >= 0)
        {
            int x = i >= 0 ? num1[i] - '0' : 0;
            int y = j >= 0 ? num2[j] - '0' : 0;
            int sum = x + y + carry;

            if (sum > 9)
            {
                carry = 1;
                sum %= 10;
            }
            else
            {
                carry = 0;
            }

            result[k] = (char)(sum + 48);
            i--;
            j--;
            k--;
        }

        if (carry > 0)
        {
            result[k] = (char)(carry + 48);
        }
        else
        {
            k++;
        }

        return result.AsSpan().Slice(k).ToString();
    }
}
