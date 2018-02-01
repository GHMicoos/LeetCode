using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            ListNode result = new ListNode(int.MinValue);
            ListNode index = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    index.next=new ListNode(l1.val);
                    index = index.next;

                    l1 = l1.next;
                }
                else
                {
                    index.next = new ListNode(l2.val);
                    index = index.next;
                    l2 = l2.next;
                }
            }
            if (l1 != null)
            {
                while (l1 != null)
                {
                    index.next = new ListNode(l1.val);
                    index = index.next;
                    l1 = l1.next;
                }
            }
            if (l2 != null)
            {
                while (l2 != null)
                {
                    index.next = new ListNode(l2.val);
                    index = index.next;
                    l2 = l2.next;
                }
            }

            return result.next;
        }
    }
}
