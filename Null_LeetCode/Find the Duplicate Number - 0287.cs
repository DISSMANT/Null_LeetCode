namespace Null_LeetCode
{
    public class FindTheDuplicateNumber0287
    {
        public int FindDuplicate(int[] nums)
        {
            var slow = 0;
            var fast = 0;

            while (slow != fast || fast + slow == 0)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }

            var findSlow = 0;

            while (findSlow != slow)
            {
                findSlow = nums[findSlow];
                slow = nums[slow];
            }
            
            return slow;
        }
    }
}