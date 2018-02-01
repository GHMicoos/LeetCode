using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public class StackNode
    {
        public int Value { get; set; }
        
    }

    public class MinStack
    {
        private IList<int> _stack;
        /** initialize your data structure here. */
        public MinStack()
        {
            this._stack = new List<int>();
        }

        public void Push(int x)
        {
            if (this._stack == null)
            {
                this._stack = new List<int>();
            }
            this._stack.Add(x);
        }

        public void Pop()
        {
            if (this._stack.Count > 0)
            {
                this._stack.RemoveAt(this._stack.Count - 1);
            }
        }

        public int Top()
        {
            if (this._stack == null || this._stack.Count == 0)
            {
                throw new Exception("Stack is empty or null!");
            }
            return this._stack[this._stack.Count - 1];
        }

        public int GetMin()
        {
            return this._stack.Min();
        }
    }

}
