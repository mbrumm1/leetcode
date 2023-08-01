namespace leetcode;
public sealed class Solution_0033_SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        int lo = 0;
        int hi = nums.Length - 1;
        bool rotated = nums[0] > nums[^1];

        while (lo <= hi)
        {
            int mid = (hi - lo) / 2 + lo;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if ((rotated && nums[lo] <= target) || nums[mid] > target)
            {
                hi = mid - 1;
            }
            else if ((rotated && nums[hi] >= target) || nums[mid] < target)
            {
                lo = mid + 1;
            }
            else
            {
                break;
            }
        }

        return -1;
    }
}
