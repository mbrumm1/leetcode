using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0637_AverageOfLevelsInBinaryTree
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        var ans = new List<double>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            double count = queue.Count;
            double divisor = count;
            double sum = 0;

            while (count > 0)
            {
                var node = queue.Dequeue();
                sum += node.val;

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }

                count--;
            }

            ans.Add(sum / divisor);
        }

        return ans;
    }
}
