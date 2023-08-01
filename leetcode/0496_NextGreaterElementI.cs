namespace leetcode;
public sealed class Solution_0496_NextGreaterElementI
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var ans = new int[nums1.Length];
        for (int i = 0; i < ans.Length; ++i)
        {
            ans[i] = -1;
        }

        for (int i = 0; i < nums1.Length; ++i) 
        {
            int elementIndex = nums2.Length; 
            for (int j = 0; j < nums2.Length; ++j)
            {
                if (nums1[i] == nums2[j])
                {
                    elementIndex = j;
                }
                else if (j > elementIndex && nums2[j] > nums1[i])
                {
                    ans[i] = nums2[j];
                    break;
                }
            }
        }

        return ans;
    }
}
