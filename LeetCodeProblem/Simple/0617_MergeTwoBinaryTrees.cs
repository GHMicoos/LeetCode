using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
   

    public partial class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return null;
            }
            else if (t1 == null)
            {
                return t2;
            }
            else if (t2 == null)
            {
                return t1;
            }
            TreeNode result = new TreeNode(t1.val+t2.val);
            TreeNode left = MergeTrees(t1.left,t2.left);
            TreeNode right = MergeTrees(t1.right, t2.right);
            result.left = left;
            result.right = right;

            return result;
        }
    }
}
