using System;

namespace Null_LeetCode
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new BestTimeToBuyAndSellStock().MaxProfit(new int[] {2, 1, 4}));
        }
    }
}