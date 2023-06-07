using System;
using System.Collections.Generic;

namespace Null_LeetCode
{
    public class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            var hash = new HashSet<int>();
            foreach (var num in nums)
                hash.Add(num);

            var count = 0;

            foreach (var num in hash)
            {
                if (!hash.Contains(num - 1))
                {
                    var current = num;
                    var currentCount = 1;

                    while (hash.Contains(current + 1))
                    {
                        current++;
                        currentCount++;
                    }

                    count = Math.Max(count, currentCount);
                }
            }

            return count;
        }
    }
}