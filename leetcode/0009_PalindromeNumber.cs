public class Solution_0009_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int forward = x;
        int lastDigit = 0;
        int reverse = 0;

        while (x > 0)
        {
            lastDigit = x % 10;
            reverse = reverse * 10 + lastDigit;
            x /= 10;
        }

        return forward == reverse;
    }
}

