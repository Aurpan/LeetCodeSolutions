using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_121_Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 2,1,2,1,0,1,2 };

            int profit = new Solution().MaxProfit(prices);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyIndx = 0, sellIndx = 1;

            while (sellIndx < prices.Length)
            {
                if ((prices[sellIndx] - prices[buyIndx]) < 0)
                {
                    buyIndx = sellIndx;
                    sellIndx++;
                }
                else
                {
                    maxProfit = Math.Max(prices[sellIndx] - prices[buyIndx], maxProfit);
                    sellIndx++;
                }
            }

            return maxProfit;
        }
    }
}
