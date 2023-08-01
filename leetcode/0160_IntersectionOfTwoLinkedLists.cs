namespace leetcode;
public sealed class Solution_0160_IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int aCount = GetCount(headA);
        int bCount = GetCount(headB);

        if (aCount > bCount)
        {
            return GetIntersection(aCount - bCount, headA, headB);
        }
        else
        {
            return GetIntersection(bCount - aCount, headB, headA);
        }
    }

    public int GetCount(ListNode node)
    {
        var current = node;
        int count = 0;

        while (current is not null)
        {
            count++;
            current = current.next;
        }

        return count;
    }

    public ListNode GetIntersection(int difference, ListNode longer, ListNode shorter)
    {
        var currentLonger = longer;

        for (int i = 1; i <= difference; i++)
        {
            currentLonger = currentLonger.next;
        }

        var currentShorter = shorter;
        ListNode intersection = null;

        while (currentLonger is not null)
        {
            if (currentLonger == currentShorter)
            {
                intersection = currentLonger;
                break;
            }

            currentLonger = currentLonger.next;
            currentShorter = currentShorter.next;
        }

        return intersection;
    }

}
