using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode result = new ListNode(head.val);
            while (head.next != null)
            {
                head = head.next;
                ListNode temp = new ListNode(head.val);
                temp.next = result;
                result = temp;
            }
            return result;
        }

        public ListNode ReverseList_02(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }
            ListNode result = null;
            ListNode index = null;
            while (stack.Count > 0)
            {
                int val = stack.Pop();
                if (result == null)
                {
                    result = new ListNode(val);
                    index = result;
                }
                else
                {
                    index.next = new ListNode(val);
                    index = index.next;
                }
            }
            return result;
        }
    }
}
