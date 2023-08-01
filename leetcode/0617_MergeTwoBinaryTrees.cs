namespace leetcode;
public sealed class Solution_0617_MergeTwoBinaryTrees
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 is null && root2 is null)
        {
            return null;
        }

        if (root1 is not null && root2 is null)
        {
            return root1;
        }

        if (root1 is null && root2 is not null)
        {
            return root2;
        }

        var left = MergeTrees(root1.left, root2.left);
        var right = MergeTrees(root1.right, root2.right);
        root1.val += root2.val;
        root1.left = left;
        root1.right = right;
        return root1;
    }
}
