using System;
using System.Collections.Generic;

namespace Null_LeetCode
{
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var length = nums.Length - 3;
            Array.Sort(nums);

            IList<IList<int>> outList = new List<IList<int>>();

            for (var x = 0; x <= length; x++)
            {
                int left = x + 1, right = length + 2;
                var target = nums[x];

                if (x > 0 && target == nums[x - 1])
                    continue;

                while (left < right)
                {
                    if (right < length + 2 && nums[right] == nums[right + 1])
                    {
                        right--;
                        continue;
                    }
                    
                    var sum = nums[left] + nums[right] + target;
                    
                    if (sum == 0)
                    {
                        outList.Add(new List<int> { target, nums[left], nums[right] });
                        left++;
                        right--;
                        continue;
                    }

                    if (sum < 0) left++;
                    else if (sum > 0) right--;
                }
            }

            return outList;
        }
    }
}