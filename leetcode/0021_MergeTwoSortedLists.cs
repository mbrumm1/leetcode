namespace leetcode
{
    public class Solution_0021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 != null && l2 == null) return l1;
            if (l1 == null && l2 != null) return l2;

            ListNode head;

            if (l1.val < l2.val)
            {
                head = l1;
            }
            else
            {
                head = l2;
                l2 = l1;
                l1 = head;
            }

            while (l1.next != null)
            {
                if (l1.next.val > l2.val)
                {
                    ListNode temp = l1.next;
                    l1.next = l2;
                    l2 = temp;
                }
                l1 = l1.next;
            }

            l1.next = l2;
            return head;
        }
    }
}
