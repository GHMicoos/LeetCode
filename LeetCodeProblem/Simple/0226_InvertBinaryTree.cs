using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null || (root.right == null && root.left == null))
            {
                return root;
            }
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;

        }
    }
}
