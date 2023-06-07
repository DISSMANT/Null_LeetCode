using System;

namespace Null_LeetCode
{
    public class TwoSum0167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var length = numbers.Length - 1;
            
            var leftPointer = 0;
            var rightPointer = length;

            var outIndexes = new int[2];

            while (leftPointer < rightPointer)
            {
                var sum = numbers[leftPointer] + numbers[rightPointer];
                if (sum > target)
                    rightPointer--;
                else if (sum < target)
                    leftPointer++;
                else
                {
                    outIndexes[0] = leftPointer + 1;
                    outIndexes[1] = rightPointer + 1;
                    break;
                }
            }

            return outIndexes;
        }
    }
}