using leetcode;
using System;

//for (int i = 1; i < 60; i *= 2)
//{
//    Console.WriteLine($"{i} % 3 = {i % 3}");
//}



//var test = new Solution_0006_ZigzagConversion();
//string result = test.Convert("SAINTARNOLDLAWNMOWERPARADISEPARK", 10);
//Console.WriteLine(result);

var test = new Solution_0034_FindFirstAndLastPositionOfElementInSortedArray();
var x = test.SearchRange(new[] { 2, 2 }, 2); 
Console.WriteLine();

void WalkTree(
    TreeNode current, 
    Action<TreeNode> preAction = null,
    Action<TreeNode> inAction = null,
    Action<TreeNode> postAction = null)
{
    if (current is null)
    {
        return;
    }

    preAction?.Invoke(current);
    WalkTree(current.left, preAction, inAction, postAction);
    inAction?.Invoke(current);
    WalkTree(current.right, preAction, inAction, postAction);
    postAction?.Invoke(current);
}