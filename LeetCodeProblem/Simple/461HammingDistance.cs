using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    #region << 类 描 述 >>
    /// <summary>
    /// 功能描述 ：HammingDistance  
    /// 创建信息 ：2018/1/22 9:59:30  MiCoos    
    /// 修改信息 ：2018/1/22 9:59:30  MiCoos    
    /// </summary>
    #endregion
   public partial class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int result = 0;
            string s1 = Convert.ToString(x,2);
            string s2 = Convert.ToString(y, 2);
            int len = Math.Max(s1.Length,s2.Length);
            while (s1.Length < len || s2.Length < len)
            {
                if (s1.Length < len)
                {
                    s1 = "0" + s1;
                }
                if (s2.Length < len)
                {
                    s2 = "0" + s2;
                }
            }
            for (int i = 0; i < len; i++)
            {
                if (s1[i] != s2[i])
                {
                    result++;
                }
            }
            
            return result;
        }


        public int HammingDistance_01(int x, int y)
        {
            int result = 0;
            string xorstring = Convert.ToString(x^y,2);
            for (int i = 0, ilen = xorstring.Length; i < ilen; i++)
            {
                if (xorstring[i] == '1')
                {
                    result++;
                }
            }
            return result;
        }

    }
}
