namespace Null_LeetCode
{
    public class RemoveNthNodeFromEndOfList0019
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || head.next == null)
                return null;
            
            var newHead = new ListNode { next = head };
            head = newHead;
            
            var left = head;
            var right = newHead;
            for (var x = 0; x < n; x++)
                right = right.next;
            
            while (right.next != null)
            {
                left = left.next;
                right = right.next;
            }
            
            left.next = left.next.next;
            
            return head.next;
        }
    }
}