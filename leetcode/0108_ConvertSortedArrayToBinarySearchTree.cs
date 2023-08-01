namespace leetcode;
public sealed class Solution_0108_ConvertSortedArrayToBinarySearchTree
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 1)
        {
            return new TreeNode(nums[0]);
        }

        return Insert(null, nums, 0, nums.Length - 1);
    }

    private TreeNode Insert(TreeNode node, int[] nums,  int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int mid = (start + end) / 2;
        node = new TreeNode(nums[mid]);
        node.left = Insert(node, nums, start, mid - 1);
        node.right = Insert(node, nums, mid + 1, end);
        return node;
    }
}
