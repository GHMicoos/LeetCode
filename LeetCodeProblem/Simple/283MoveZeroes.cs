using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0, ilen = nums.Length-1; i < ilen; i++)
            {
                if (nums[i] == 0)
                {
                    bool change = false;
                    for (int j = i + 1,jlen=nums.Length; j < jlen; j++)
                    {
                        if (nums[j] != 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            change = true;
                            break;
                        }
                    }
                    if (!change)
                    {
                        break;
                    }
                }

            }
        }
    }
}
