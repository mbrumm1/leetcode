namespace leetcode;
public class Solution_0303_RangeSumQueryImmutable
{
    // TODO: optimize this later by caching a running total array in constructor.
    public sealed class NumArray
    {
        private readonly int[] nums;

        public NumArray(int[] nums)
        {
            this.nums = nums;
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;
            for (int i = left; i <= right; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
