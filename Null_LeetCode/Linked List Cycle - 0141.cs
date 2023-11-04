namespace Null_LeetCode
{
    public class LinkedListCycle0141
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (slow == fast) return true;
            }

            return false;
        }
    }
}