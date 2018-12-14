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
            int maxProfit = 0;
            List<ProfitData> data = new List<ProfitData>();
            for (int index = 0; index < prices.Length; ++index)
            {
                ProfitData profit = new ProfitData() {DaySold = prices[-index], TotalProfit = 0};

            }
            return maxProfit;
        }
    }

    internal class ProfitData
    {
        private int totalProfit;
        private int daySold;

        public int TotalProfit { get => totalProfit; set => totalProfit = value; }
        public int DaySold { get => daySold; set => daySold = value; }
    }
}
