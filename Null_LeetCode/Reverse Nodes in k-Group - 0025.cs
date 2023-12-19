namespace Null_LeetCode;

public class ReverseNodesInKGroup0025
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {

        return head;
    }
    
    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;

        var newHead = head;
        if (head.next != null)
        {
            newHead = ReverseList(head.next);
            head.next.next = head;
        }

        head.next = null;

        return newHead;
    }
}