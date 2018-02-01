using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0, ilen = prices.Length; i < ilen; i++)
            {
                int item = prices[i];
                if (item < min)
                {
                    min = item;
                }
                else if (item - min > maxprofit)
                {
                    maxprofit = item - min;
                }
            }
            return maxprofit;
        }
    }
}
