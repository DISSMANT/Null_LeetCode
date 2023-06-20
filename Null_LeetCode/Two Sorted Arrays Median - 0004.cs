using System;

namespace Null_LeetCode
{
    public class TwoSortedArraysMedian0004
    {
        public double FindMedianSortedArrays(int[] first, int[] second)
        {
            var total = first.Length + second.Length;
            var halfTotal = total / 2;
            var (small, big) = first.Length > second.Length ? (second, first) : (first, second);

            var left = 0;
            var right = small.Length - 1;

            for (;;) 
            {
                var pointerS = (right - left - 1) / 2 + left;
                var pointerB = halfTotal - pointerS - 2;
                
                var smallLeft = pointerS >= 0 ? small[pointerS] : int.MinValue;
                var smallRight = pointerS + 1 < small.Length ? small[pointerS + 1] : int.MaxValue;

                var bigLeft = pointerB >= 0 ? big[pointerB] : int.MinValue;
                var bigRight = pointerB + 1 < big.Length ? big[pointerB + 1] : int.MaxValue;
                

                if (smallLeft <= bigRight && bigLeft <= smallRight)
                {
                    if (total % 2 == 1)
                        return Math.Min(smallRight, bigRight);
                    return (Math.Max(smallLeft, bigLeft) + Math.Min(smallRight, bigRight)) / 2f;
                }
                else if (smallLeft > bigRight)
                    right = pointerS - 1;
                else
                    left = pointerS + 1;
            }
        }
    }
}