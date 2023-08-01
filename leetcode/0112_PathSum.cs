using Dia2Lib;
using Microsoft.Diagnostics.Tracing.StackSources;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0112_PathSum
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        targetSum -= root.val;

        if (targetSum == 0 && root.left is null && root.right is null)
        {
            return true;
        }

        bool hasPathSum = false;

        if (root.left is not null)
        {
            hasPathSum |= HasPathSum(root.left, targetSum);
        }

        if (root.right is not null)
        {
            hasPathSum |= HasPathSum(root.right, targetSum);
        }

        return hasPathSum;
    }

    public bool HasPathSum2(TreeNode root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        return HasPathSum2(root, targetSum, 0);
    }

    public bool HasPathSum2(TreeNode root, int targetSum, int runningTotal)
    {
        runningTotal += root.val;

        if (root.left is null && root.right is null)
        {
            return runningTotal == targetSum;
        }

        if (root.left is not null)
        {
            if (HasPathSum2(root.left, targetSum, runningTotal))
            {
                return true;
            }
        }

        if (root.right is not null)
        {
            if(HasPathSum2(root.right, targetSum, runningTotal))
            {
                return true;
            }
        }

        return false;
    }
}


