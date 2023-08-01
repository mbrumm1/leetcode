namespace leetcode;
public sealed class Solution_0338_CountingBits
{
    public int[] CountBits(int n)
    {
        int[] ans = new int[n + 1];
        for (int i = 0; i < ans.Length; i++) 
        {
            ans[i] = CountOnes(i);
        }
        return ans;
    }

    private int CountOnes(int n)
    {
        int oneCount = 0;
        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                ++oneCount;
            }
            n >>= 1;
        }
        return oneCount;
    }
}
