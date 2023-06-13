using System;

namespace Null_LeetCode
{
    public class ContainerWithMostWater0011
    {
        public int MaxArea(int[] height)
        {
            var length = height.Length;

            var left = 0;
            var right = length - 1;
            var maxS = 0;
            
            while (left < right)
            {
                var s = Math.Min(height[left], height[right]) * (right - left);
                if (maxS < s)
                    maxS = s;

                if (height[left] < height[right]) left++;
                else right--;
            }
            
            return maxS;
        }
    }
}