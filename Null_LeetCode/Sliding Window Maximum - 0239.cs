using System.Collections.Generic;

namespace Null_LeetCode
{
    public class Sliding_Window_Maximum___0239
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var output = new List<int>();
            var queue = new LinkedList<int>();

            var left = 0;
            var right = 0;

            while (right < nums.Length)
            {
                while (queue.Count > 0 && nums[queue.Last.Value] < nums[right])
                    queue.RemoveLast();

                queue.AddLast(right);

                if (left > queue.First.Value)
                    queue.RemoveFirst();

                if (right + 1 >= k)
                {
                    output.Add(nums[queue.First.Value]);
                    left++;
                }

                right++;
            }
            
            return output.ToArray();
        }
    }
}