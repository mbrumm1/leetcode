using System;
using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0530_MinimumAbsoluteDifferenceInBST
{
    public void Walk(TreeNode current, List<int> values)
    {
        if (current == null)
        {
            return;
        }

        Walk(current.left, values);
        values.Add(current.val);
        Walk(current.right, values);
    }

    public int GetMinimumDifference(TreeNode root)
    {
        var values = new List<int>();
        Walk(root, values);

        int minimumDifference = int.MaxValue;
        for (int i = 1; i < values.Count; ++i)
        {
            int difference = Math.Abs(values[i] - values[i - 1]);
            if (difference < minimumDifference)
            {
                minimumDifference = difference;
            }

            if (minimumDifference == 0)
            {
                return minimumDifference;
            }
        }

        return minimumDifference;
    }
}
