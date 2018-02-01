using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB==null)
            {
                return null;
            }
            ListNode result = headA;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            while (result != null)
            {
                if (!dic.ContainsKey(result.val))
                {
                    dic[result.val] = 0;
                }
                dic[result.val]++;
                result = result.next;
            }
            result = headB;
            while (result != null)
            {
                if (dic.ContainsKey(result.val))
                {
                    break;
                }
                result = result.next;
            }
            return result;

        }
    }
}
