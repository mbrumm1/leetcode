namespace leetcode;
public sealed class Solution_0441_ArrangingCoins
{
    public int ArrangeCoins(int n)
    {
        int i = 1;
        int completeRows = 0;

        while (n > 0)
        {
            int d = n - i;

            if (d >= 0)
            {
                completeRows++;
            }

            n -= i++;
        }

        return completeRows;
    }
}
