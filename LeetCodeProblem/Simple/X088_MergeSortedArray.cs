using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0, len = n - 1; i < len; i++)
            {
                int item = nums2[i];
                int j = 0;
                int jlen = m - 1;
                for ( ; j < jlen; j++)
                {
                    int jitem = nums1[j];
                    if (jitem >= item)
                    {
                        //当前i 后羿
                        for (int k = nums1.Length-1; k > j; k--)
                        {
                            nums1[k] = nums1[k - 1];
                        }
                        nums1[j] = jitem;
                        break;
                    }
                }
            }
        }
    }
}
