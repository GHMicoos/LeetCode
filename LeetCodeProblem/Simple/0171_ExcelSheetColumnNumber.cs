using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public int TitleToNumber(string s)
        {

            if (s == null)
            {
                throw new Exception("no result!");
            }
            int result = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 65; i <= 90; i++)
            {
                dic.Add((char)i, i - 64);
            }
            int basic = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char item = s[i];
                if (dic.ContainsKey(item))
                {
                    result += dic[item] * basic;
                }
                basic *= 26;
            }
            return result;

        }
    }
}
