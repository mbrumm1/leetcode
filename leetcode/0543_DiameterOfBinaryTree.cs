using System;

namespace leetcode;
public sealed class Solution_0543_DiameterOfBinaryTree
{
    private int longest = 0;

    private int Walk(TreeNode current)
    {
        if (current is null)
        {
            return 0;
        }

        if (current.left is null && current.right is null)
        {
            return 1;
        }

        int left = Walk(current.left);
        int right = Walk(current.right);

        longest = Math.Max(longest, left + right);
        return left >= right ? left + 1 : right + 1;
    }

    public int DiameterOfBinaryTree(TreeNode root)
    {
        Walk(root);
        return longest;
    }
}
