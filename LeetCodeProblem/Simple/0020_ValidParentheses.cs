using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public bool IsValid(string s)
        {
            if (s == null)
            {
                return false;
            }
            bool result = true;
            Stack<char> stack = new Stack<char>();
            for (int i = 0, ilen = s.Length; i < ilen; i++)
            {
                char item = s[i];
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    if (stack.Count == 0)
                    {
                        result = false;
                        break;
                    }
                    else
                    {
                        char pop = stack.Pop();
                        if ((pop == '(' && item == ')')
                            || (pop == '[' && item == ']')
                            || pop == '{' && item == '}')
                        {
                            continue;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            if (stack.Count != 0)
            {
                result = false;
            }
            return result;
        }
    }
}
