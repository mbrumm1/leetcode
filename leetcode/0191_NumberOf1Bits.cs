namespace leetcode;
public sealed class Solution_0191_NumberOf1Bits
{
    public int HammingWeight(uint n)
    {
        int hammingWeight = 0;

        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                hammingWeight++;
            }

            n >>= 1;
        }

        return hammingWeight;
    }
}
