using System;

namespace Null_LeetCode
{
    public class BinarySearch0704
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = (right - left) / 2 + left;

                if (nums[middle] == target)
                    return middle;

                if (nums[middle] > target) 
                    right = middle - 1;
                else 
                    left = middle + 1;
            }
            
            return -1;
        }        
    }
}