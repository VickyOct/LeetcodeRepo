public class Solution
{
    public ListNode RemoveNodes(ListNode head)
    {
        ListNode dummy = head;
        ListNode rev = null;

        while(dummy != null)
        {
            ListNode temp = dummy.next;
            dummy.next = rev;
            rev = dummy;
            dummy = temp;
        }


        ListNode NewList = null;
        int MaxValue = int.MinValue;

        while(rev != null)
        {
            if(rev.val >= MaxValue)
            {
                MaxValue = rev.val;
                ListNode temp = rev.next;
                rev.next = NewList;
                NewList = rev;
                rev = temp;
            }
            else
            {
                rev = rev.next;
            }
        }

        return NewList;
    }
}