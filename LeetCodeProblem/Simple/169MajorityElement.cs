using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int result = 0;
            int count = nums.Length / 2;
            
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0, ilen = nums.Length; i < ilen; i++)
            {
                int item = nums[i];
                if (!dic.ContainsKey(item))
                {
                    dic[item] = 0;
                }
                dic[item]++;
                if (dic[item] > count)
                {
                    result = item;
                    break;
                }
                else if (dic[item] == count)
                {
                    result = item;
                }
            }
            return result;
        }
    }
}
