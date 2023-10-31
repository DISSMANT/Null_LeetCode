using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Null_LeetCode
{
    public class CopyListWithRandomPointer0138
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            
            var oldToNew = new Dictionary<Node, Node>();
            
            var tail = head;
            
            while (tail != null)
            {
                oldToNew.Add(tail, new Node(tail.val));
                tail = tail.next;
            }

            tail = head;
            while (tail != null)
            {
                oldToNew[tail].next = tail.next != null ? oldToNew[tail.next] : null;
                oldToNew[tail].random = tail.random != null ? oldToNew[tail.random] : null;
                tail = tail.next;
            }

            return oldToNew[head];
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}