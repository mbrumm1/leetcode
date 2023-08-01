namespace leetcode;
public sealed class Solution_0002_AddTwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var head = new ListNode();
        var current = head;
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            int x = l1?.val ?? 0;
            int y = l2?.val ?? 0;
            int sum = carry + x + y;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        if (carry > 0) current.next = new(carry);
        return head.next;
    }
}

