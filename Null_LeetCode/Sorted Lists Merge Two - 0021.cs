using System.Net.Sockets;

namespace Null_LeetCode
{
    public class SortedListsMergeTwo0021
    {
        public ListNode MergeTwoLists(ListNode pointerLeft, ListNode pointerRight)
        {
            var final = new ListNode();
            var tail = final;
            
            while (pointerLeft != null && pointerRight != null)
            {
                if (pointerLeft.val <= pointerRight.val)
                {
                    tail.next = pointerLeft;
                    pointerLeft = pointerLeft.next;
                }
                else
                {
                    tail.next = pointerRight;
                    pointerRight = pointerRight.next;
                }

                tail = tail.next;
            }

            if (pointerLeft != null)
                tail.next = pointerLeft;
            else if (pointerRight != null)
                tail.next = pointerRight;

            return final.next;
        }
    }
}