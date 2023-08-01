namespace leetcode;
public sealed class Solution_0572_SubtreeOfAnotherTree
{
    private bool IsIdentical(TreeNode current, TreeNode subCurrent)
    {
        if (current is null && subCurrent is null)
        {
            return true;
        }

        if (current is null || subCurrent is null)
        {
            return false;
        }

        if (current.val != subCurrent.val)
        {
            return false;
        }

        return IsIdentical(current.left, subCurrent.left) 
            && IsIdentical(current.right, subCurrent.right); 
    }

    private bool Walk(TreeNode current, TreeNode subCurrent)
    {
        if (current is null)
        {
            return false;
        }

        return IsIdentical(current, subCurrent) 
            || Walk(current.left, subCurrent) 
            || Walk(current.right, subCurrent);
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root.left is null && root.left is null && 
            subRoot.left is null && subRoot.right is null 
            && root.val == subRoot.val)
        {
            return true;
        }

        return Walk(root, subRoot);
    }
}
