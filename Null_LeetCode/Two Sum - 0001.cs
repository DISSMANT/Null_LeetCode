using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;

namespace Null_LeetCode
{
    public class TwoSum0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var breakFlag = false;

            for (var x = 0; x < nums.Length - 1; x++)
            {
                if (breakFlag)
                    break;
                for (var y = x + 1; y < nums.Length; y++)
                    if (nums[x] + nums[y] == target)
                    {
                        result = new[] { x, y };
                        breakFlag = true;
                        break;
                    }
            }

            return result;
        }

        public int[] ExceptionalTwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var x = 0; x < nums.Length; x++)
            {
                var diff = target - nums[x];
                if (dict.ContainsKey(diff))
                    return new [] { dict[diff], x };
                if (!dict.ContainsKey(nums[x]))
                    dict.Add(nums[x], x);
            }
            return default;
        }
    }
}