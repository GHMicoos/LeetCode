using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            ConvertBST(root.right);
            sum += root.val;
            root.val = sum;
            ConvertBST(root.left);
            return root;
        }
    }
}
