using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0, ilen = result.Length; i < ilen; i++)
            {
                result[i] = i+1;
            }
            for (int i = 0, ilen = result.Length; i < ilen; i++)
            {
                int number = nums[i];
                result[number-1] -= number;
            }
            

            return result.Where(x=>x>0).ToList();
        }

        public IList<int> FindDisappearedNumbers_02(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0, ilen = nums.Length; i < ilen; i++)
            {
                dic[i+1] = 0;
            }
            foreach (int item in nums)
            {
                dic[item] = 1;
            }
            return dic.Where(x=>x.Value==0).Select(x=>x.Key).ToList();
        }
    }
}
