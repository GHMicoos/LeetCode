using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public string ReverseString(string s)
        {
            if (s == null)
            {
                return s;
            }
            StringBuilder strbulid = new StringBuilder();
            for (int i = s.Length-1; i >= 0; i--)
            {
                strbulid.Append(s[i]);
            }

            return strbulid.ToString();
        }
    }
}
