using System;

namespace Null_LeetCode
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            var left = 0;
            var right = 1;
            
            while (right < prices.Length)
            {
                if (prices[left] < prices[right]) maxProfit = Math.Max(prices[right] - prices[left], maxProfit);
                else left = right;
                right++;
            }

            return maxProfit;
        }
    }
}