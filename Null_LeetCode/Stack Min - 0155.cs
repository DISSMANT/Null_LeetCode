using System.Collections.Generic;

namespace Null_LeetCode
{
    public class MinStack {

        private Stack<int> data;
        private Stack<int> minData;
        public MinStack()
        {
            data = new Stack<int>();
            minData = new Stack<int>();
        }
    
        public void Push(int val)
        {
            data.Push(val);
            if (minData.Count == 0)
                minData.Push(val);
            else if (minData.Peek() >= val)
                minData.Push(val);
        }
    
        public void Pop()
        {
            if (data.Peek() == minData.Peek())
                minData.Pop();
            data.Pop();
        }
    
        public int Top()
        {
            return data.Peek();
        }
    
        public int GetMin()
        {
            return minData.Peek();
        }
    }
}