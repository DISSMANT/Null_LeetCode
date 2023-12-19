using System;

namespace Null_LeetCode;

public class MergeKSortedLists
{
    public void TestToTest()
    {
        var lists = new ListNode[3];
        lists[0] = new ListNode(1, new ListNode(4, new ListNode(5)));
        lists[1] = new ListNode(1, new ListNode(3, new ListNode(4)));
        lists[2] = new ListNode(2, new ListNode(6));
        
        var result = MergeKLists(lists);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
    
    public ListNode MergeKLists(ListNode[] lists)
    {
        var amount = lists.Length;
        
        if (amount == 0)
            return null;
        
        var interval = 1;
        while (interval < amount)
        {
            for (var i = 0; i < amount - interval; i += interval * 2)
            {
                lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
            }

            interval *= 2;
        }
        
        return lists[0];
    }

    private ListNode MergeTwoLists(ListNode pointerLeft, ListNode pointerRight)
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