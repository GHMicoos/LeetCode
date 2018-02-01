using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public int Rob(int[] nums)
        {
            int oddMax = 0;
            int evenMax = 0;
            for (int i = 0, ilem = nums.Length; i < ilem; i++)
            {
                if (i % 2 == 0)
                {
                    evenMax += nums[i];
                }
                else
                {
                    oddMax += nums[i];
                }
            }
            return Math.Max(oddMax,evenMax);
        }
    }
}
