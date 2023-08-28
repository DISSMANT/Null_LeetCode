using System.Collections.Generic;

namespace Null_LeetCode
{
    public class DailyTemperatures0739
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<(int, int)>();
            var length = temperatures.Length;
            var result = new int[length];
            
            stack.Push((temperatures[0], 0));
            
            for (var x = 1; x < length; x++)
            {
                if (stack.Peek().Item1 < temperatures[x])
                    while (stack.Count > 0 && stack.Peek().Item1 < temperatures[x])
                    {
                        var t = stack.Pop();
                        result[t.Item2] = x - t.Item2;
                    }
                stack.Push((temperatures[x], x));
            }
            
            return result;
        }
    }
}