namespace Null_LeetCode
{
    public class ReorderList0143
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null) return;
            
            var slow = head;
            var fast = head.next;
            
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var middle = slow.next;
            slow.next = null;
            
            var reversedList = ReverseList(middle);

            var first = head;
            var second = reversedList;

            while (second != null)
            {
                var tempOne = first.next;
                var tempTwo = second.next;

                first.next = second;
                second.next = tempOne;
                first = tempOne;
                second = tempTwo;
            }

            return;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

            var current = head;

            while (current != null)
            {
                var temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            
            return prev;
        }
    }
}