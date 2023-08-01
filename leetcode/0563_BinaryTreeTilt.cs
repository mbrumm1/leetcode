using System;

namespace leetcode;
public sealed class Solution_0563_BinaryTreeTilt
{
    private int sum = 0;

    private int Walk(TreeNode current)
    {
        if (current is null)
        {
            return 0;
        }

        int left = Walk(current.left);
        int right = Walk(current.right);
        sum += Math.Abs(left - right);
        return current.val + left + right;
    }

    public int FindTilt(TreeNode root)
    {
        Walk(root);
        return sum;
    }
}
