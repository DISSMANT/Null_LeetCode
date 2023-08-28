using System;
using System.Collections.Generic;
using System.Linq;

namespace Null_LeetCode
{
    public class CarFleet0853
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            var pairs = new (int position, int target)[position.Length];

            for (var x = 0; x < position.Length; x++)
                pairs[x] = (position[x], speed[x]);

            var stack = new Stack<double>();
            var reversed = pairs.OrderBy(x => -x.position);
            // Array.Sort(pairs, Comparer<(int, int)>.Create((p, y) => -p.Item1));
            // Array.Sort(position, speed, Comparer<int>.Create((a, b) => b - a));
            foreach (var (p, s) in reversed)
            {
                var timeToFinish = (double)(target - p) / s;
                if (stack.Count == 0) stack.Push(timeToFinish);
                else
                {
                    if (stack.Peek() < timeToFinish)
                        stack.Push(timeToFinish);
                }
            }

            return stack.Count;
        }
    }
}