/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = 0;
        ListNode curr = head;

        while (curr != null)
        {
            length++;
            curr = curr.next;
        }

        int traverseTill = length - n - 1;
        curr = head;

        for (int i = 0; i < traverseTill; i++)
        {
            curr = curr.next;
        }

        if (traverseTill == -1)
        {
            return head.next;
        }
        else
        {
            curr.next = curr.next.next;
            return head;
        }
    }
}