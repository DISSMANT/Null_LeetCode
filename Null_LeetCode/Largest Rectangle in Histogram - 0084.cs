using System.Collections.Generic;

namespace Null_LeetCode
{
    public class LargestRectangleInHistogram0084
    {
        public int LargestRectangleArea(int[] heights)
        {
            var stack = new Stack<(int index, int value)>();
            var length = heights.Length;

            stack.Push((0, heights[0]));

            var max = stack.Peek().value;

            for (var x = 1; x < length; x++)
            {
                var index = x;
                var value = heights[x];
                
                while (stack.Count > 0 && value < stack.Peek().value)
                {
                    var s = stack.Peek().value * (x - stack.Peek().index);
                    if (s > max) max = s;
                    index = stack.Pop().index;
                }
                stack.Push((index, value));
            }

            while (stack.Count > 0)
            {
                var s = stack.Peek().value * (length - stack.Peek().index);
                if (s > max) max = s;
                stack.Pop();
            }
            
            return max;
        }
    }
}