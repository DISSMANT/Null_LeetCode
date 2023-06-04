namespace Null_LeetCode
{
    public class ProductOfArrayExceptSelf0238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var length = nums.Length;
            var result = new int[length];

            var prefix = 1;
            for (var x = 0; x < length; x++)
            {
                result[x] = prefix;
                prefix *= nums[x];
            }

            var postfix = 1;
            for (var x = length - 1; x > -1; x--)
            {
                result[x] *= postfix;
                postfix *= nums[x];
            }

            return result;
        }
    }
}