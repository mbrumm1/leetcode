namespace leetcode;
public sealed class Solution_0258_AddDigits
{
    public int AddDigits(int num)
    {
        if (num < 10)
        {
            return num;
        }

        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;

            if (num == 0 && sum > 9)
            {
                num = sum;
                sum = 0;
            }
        }
        return sum;
    }

    public int AddDigitsNumberTheory(int num) 
    {
        int remainder = num % 9;
        return num > 0 && remainder == 0 ? 9 : remainder;
    }
}
