using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using Microsoft.Extensions.Options;
using System;

namespace leetcode;
public sealed class Solution_0234_PalindromeLinkedList
{
    public bool IsPalindrome2(ListNode head)
    {
        if (head.next is null)
        {
            return true;
        }

        int count = 0;
        var countPointer = head;

        for (; countPointer != null; countPointer = countPointer.next)
        {
            count++;                       
        }

        var array = new int[count];

        for (int i = 0; head != null; head = head.next, i++)
        {
            array[i] = head.val;
        }

        for (int i = 0; i <= array.Length - 1 - i; i++)
        {
            if (array[i] != array[array.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    public bool IsPalindrome(ListNode head)
    {
        // Shortcut if it's just one node, which is still a palindrome.
        if (head.next is null)
        {
            return true;
        }

        // Get the count of nodes to determine the mid point.
        int count = 0;
        ListNode current = head;
        while (current != null)
        {
            count++;
            current = current.next;
        }

        int position = 0;
        // If a linked list has an even amount of nodes, then the mid point wouldn't actually be a node.
        // If it has an odd amount of nodes, the mid point is a node that can be ignored in the comparisons.
        int mid = count / 2;
        int remainder = count % 2;

        // The tail half of the list will be reversed.
        ListNode previous = null;
        current = head;
        ListNode next = null;

        while (current != null)
        {
            next = current.next;

            
            if (position == mid - 1)
            {
                // Cut-off the first half of the list
                current.next = null;
            }
            if (position >= mid + remainder)
            {
                current.next = previous;
            }

            previous = current;
            current = next;
            position++;
        }

        // Previous now points to the second half of the list, but reveresed.
        // Traverse the lists and compare their values. Immediately return false, if there isn't a match.
        while (head != null)
        {
            if (head.val != previous.val)
            {
                return false;
            }

            head = head.next;
            previous = previous.next;
        }

        return true;
    }
}
