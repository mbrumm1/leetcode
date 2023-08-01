using System;

namespace leetcode;
public sealed class Solution_0104_MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        int leftMaxDepth = 1 + MaxDepth(root.left);
        int rightMaxdepth = 1 + MaxDepth(root.right);
        return Math.Max(leftMaxDepth, rightMaxdepth);
    }
}

public sealed class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
