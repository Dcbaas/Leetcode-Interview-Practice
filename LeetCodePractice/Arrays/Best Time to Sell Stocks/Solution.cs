using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Best_Time_to_Sell_Stocks
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int total = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                if (prices[i + 1] > prices[i]) total += prices[i + 1] - prices[i];
            }

            return total;
        }
    }
}
