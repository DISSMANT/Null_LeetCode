namespace Null_LeetCode
{
    public class AddTwoNumbers0002
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var buff = 0;
            var newList = new ListNode();
            var start = newList;

            while (l1 != null || l2 != null || buff != 0)
            {
                var tempOne = l1?.val ?? 0;
                var tempTwo = l2?.val ?? 0;
                var tempSum = tempOne + tempTwo;
                if (buff != 0)
                    tempSum += buff;

                buff /= 10;
                buff += tempSum / 10;

                newList.next = new ListNode(tempSum % 10);
                newList = newList.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }
            
            return start.next;
        }
    }
}