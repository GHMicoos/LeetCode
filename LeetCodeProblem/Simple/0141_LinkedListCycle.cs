using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode one = head;
            ListNode two = head.next;
            while (one != two)
            {
                if (two == null || two.next == null)
                {
                    return false;
                }
                one = one.next;
                two = two.next.next;
            }
            return true;
        }
    }
}
