using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public int GetSum(int a, int b)
        {
            int jw = a & b;
            int jg = a ^ b;
            while (jw!=0)
            {
                int t_a = jg;
                int t_b = jw << 1;
                jw = t_a & t_b;
                jg = t_a ^ t_b;
            }
            return jg;
        }
    }
}
