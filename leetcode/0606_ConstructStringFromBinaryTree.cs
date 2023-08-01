using System.Text;

namespace leetcode;
public sealed class Solution_0606_ConstructStringFromBinaryTree
{
    private StringBuilder builder = new();

    private void Walk(TreeNode current)
    {
        if (current is null)
        {
            return;
        }

        builder.Append(current.val.ToString());

        if (current.left is null && current.right is not null)
        {
            builder.Append("()(");
            Walk(current.right);
            builder.Append(")");
        }
        else if (current.left is not null && current.right is null)
        {
            builder.Append("(");
            Walk(current.left);
            builder.Append(")");
        }
        else if (current.left is not null && current.right is not null)
        {
            builder.Append("(");
            Walk(current.left);
            builder.Append(")(");
            Walk(current.right);
            builder.Append(")");
        }
    }

    public string Tree2str(TreeNode root)
    {
        Walk(root);
        return builder.ToString();
    }
}
