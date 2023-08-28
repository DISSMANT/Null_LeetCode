using System;
using System.Linq;

namespace Null_LeetCode
{
    public class FindMinimumInRotatedSortedArray0153
    {
        public int FindMinWorst(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var min = nums[left];

            while (left <= right)
            {
                if (nums[left] < nums[right])
                {
                    min = Math.Min(min, nums[left]);
                    break;
                }

                var middle = (right - left) / 2 + left;

                if (nums[middle] <= min)
                    min = nums[middle];

                if (nums[middle] >= nums[left])
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            
            return min;
        }

        public int FindMin(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (nums[left] > nums[right])
            {
                var middle = (right - left) / 2 + left;

                if (nums[middle] >= nums[left])
                    left = middle + 1;
                else
                    right = middle;
            }

            return nums[left];
        }
    }
}