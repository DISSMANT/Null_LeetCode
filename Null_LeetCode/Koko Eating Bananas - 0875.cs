using System;
using System.Collections.Generic;
using System.Linq;

namespace Null_LeetCode
{
    public class KokoEatingBananas0875
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            var left = 1;
            var right = piles.Max();
            var result = 1;

            while (left <= right)
            {
                var k = (right - left) / 2 + left;
                var timeLimitNotExceed = CheckForTimeLimit(piles, h, k);

                if (timeLimitNotExceed)
                {
                    result = k;
                    right = k - 1;
                }
                else
                    left = k + 1;
            }

            return result;
        }

        private static bool CheckForTimeLimit(IEnumerable<int> piles, int h, int k)
        {
            return piles.Sum(t => Math.Ceiling((double)t / k)) <= h;
        }
    }
}