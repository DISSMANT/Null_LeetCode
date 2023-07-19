using System;

namespace Null_LeetCode
{
    public class TrappingRainWater0042
    {
        public int Trap(int[] height)
        {
            var length = height.Length;
            var left = 0;
            var right = length - 1;
            var maxLeft = height[left];
            var maxRight = height[right];

            var outPut = 0;
            
            while (left < right)
            {
                if (maxLeft > maxRight)
                {
                    right--;
                    maxRight = Math.Max(maxRight, height[right]);
                    outPut += maxRight - height[right];
                }
                else
                {
                    left++;
                    maxLeft = Math.Max(maxLeft, height[left]);
                    outPut += maxLeft - height[left];
                }
            }

            return outPut;
        }
    }
}