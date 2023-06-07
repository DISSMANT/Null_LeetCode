using System;
using System.Collections.Generic;

namespace Null_LeetCode
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var length = nums.Length - 3;
            Array.Sort(nums);

            var outList = new List<List<int>>();

            for (var x = 0; x < length; x++)
            {
                int left = x + 1, right = length + 2;

                while (left < right)
                {
                    
                }
            }
        }
    }
}