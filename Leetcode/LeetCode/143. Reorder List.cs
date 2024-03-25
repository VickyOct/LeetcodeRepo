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
    public void ReorderList(ListNode head)
    {
        ListNode prefix = head;
        ListNode suffix = head;
       
        ListNode result = null;

        while(suffix.next.next != null)
        {
            prefix = prefix.next;
            suffix = suffix.next.next;
        }
    }
}