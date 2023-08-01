namespace leetcode;
public sealed class Solution_0169_MajorityElement
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int number = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                number = nums[i];
            }

            count += number == nums[i] ? 1 : -1;
        }

        return number;
    }
}
