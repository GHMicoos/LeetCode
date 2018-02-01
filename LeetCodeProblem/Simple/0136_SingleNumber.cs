using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (int item in nums)
            {
                result ^= item;
            }
            return result;
        }
    }
}
