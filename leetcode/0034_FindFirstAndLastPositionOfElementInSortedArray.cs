namespace leetcode;
public sealed class Solution_0034_FindFirstAndLastPositionOfElementInSortedArray
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return new[] { -1, -1 };
        }

        if (nums.Length == 1 && nums[0] == target)
        {
            return new[] { 0, 0 };
        }

        return new[] { Search(nums, target, -1), Search(nums, target, 1) };
    }

    private int Search(int[] nums, int target, int direction)
    {
        int lo = 0;
        int hi = nums.Length - 1;
        int limit = direction == -1 ? 0 : nums.Length - 1;

        while (lo <= hi)
        {
            int mid = (lo + hi) / 2;

            if (nums[mid] == target && (mid == limit || nums[mid + direction] != target))
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                hi = mid - 1;
            }
            else if (nums[mid] < target)
            {
                lo = mid + 1;
            }
            else
            {
                if (direction == -1)
                {
                    hi = mid - 1;
                }
                if (direction == 1)
                {
                    lo = mid + 1;
                }
            }
        }

        return -1;
    }
}
