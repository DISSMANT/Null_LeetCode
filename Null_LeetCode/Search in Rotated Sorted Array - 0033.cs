namespace Null_LeetCode
{
    public class SearchInRotatedSortedArray0033
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var current = (right - left) / 2 + left;

                if (nums[current] == target)
                    return current;
                
                if (nums[left] <= nums[current])
                    if (target > nums[current] || target < nums[left])
                        left = current + 1;
                    else
                        right = current - 1;
                else
                {
                    if (target < nums[current] || target > nums[right])
                        right = current - 1;
                    else
                        left = current + 1;
                }
            }

            return -1;
        }
    }
}