using BenchmarkDotNet.Toolchains.NativeAot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode;
public sealed class Solution_0404_SumOfLeftLeaves
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root.left is null && root.right is null)
        {
            return 0;
        }

        return SumOfLeftLeaves(root, false);
    }

    private int SumOfLeftLeaves(TreeNode root, bool isLeftNode)
    {
        if (root is null)
        {
            return 0;
        }

        if (root.left is null && root.right is null && isLeftNode)
        {
            return root.val;
        }

        int left = SumOfLeftLeaves(root.left, true);
        int right = SumOfLeftLeaves(root.right, false);
        return left + right;
    }
}
