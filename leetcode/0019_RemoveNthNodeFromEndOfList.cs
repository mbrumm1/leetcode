namespace leetcode;
public sealed class Solution_0019_RemoveNthNodeFromEndOfList
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next is null && n == 1)
        {
            return null;
        }

        if (head.next is null && n != 1)
        {
            return head;
        }

        int size = 1;
        int pos = 1;
        var start = head;
        var slow = head;
        var fast = head;

        while (slow is not null && fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
            pos++;
            size += fast is null ? 1 : 2;
        }

        int beforeNth = size - n;

        if (beforeNth == 0)
        {
            return head.next;
        }

        if (beforeNth >= pos)
        {
            for (int i = pos; i < beforeNth; ++i)
            {
                slow = slow.next;
            }
            slow.next = slow.next.next;
        }
        else
        {
            for (int i = 1; i < beforeNth; ++i)
            {
                start = start.next;
            }
            start.next = start.next.next;
        }
        
        return head;
    }
}
