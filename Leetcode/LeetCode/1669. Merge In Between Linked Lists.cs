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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = list1;

        ListNode prefix = dummy;
        for (int i = 0; i < a; i++)
            prefix = prefix.next;

        ListNode beforeA = prefix;

        for (int i = a; i <= b; i++)
            prefix = prefix.next;

        ListNode afterB = prefix.next;

        beforeA.next = list2;
        while (list2.next != null)
            list2 = list2.next;

        list2.next = afterB;

        return dummy.next;
    }
}