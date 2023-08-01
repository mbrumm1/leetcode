namespace leetcode;
public sealed class Solution_0024_SwapNodesInPairs
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head is null || head.next is null)
        {
            return head;
        }

        var node = head.next;
        head.next = SwapPairs(head.next.next);
        node.next = head;
        return node;
    }
}
