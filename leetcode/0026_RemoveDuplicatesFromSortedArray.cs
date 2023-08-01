public class Solution_0026_RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int marker = 1;

        if (nums.Length == 1)
            return marker;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                nums[marker] = nums[i];
                marker++;
            }
        }

        return marker;
    }
}

