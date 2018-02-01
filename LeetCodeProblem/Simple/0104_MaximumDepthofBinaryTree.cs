using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{

    public partial class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = root.left == null ? 0 : MaxDepth(root.left);
            int right = root.right == null ? 0 : MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }
    }
}
