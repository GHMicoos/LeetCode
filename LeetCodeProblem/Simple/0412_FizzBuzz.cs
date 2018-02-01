using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            if (n < 1)
            { return null; }
            IList<string> result = new List<string>();
            string three = "Fizz";
            string five = "Buzz";
            string threefive = "FizzBuzz";
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                { result.Add(threefive); }
                else if (i % 3 == 0)
                { result.Add(three); }
                else if (i % 5 == 0)
                { result.Add(five); }
                else
                { result.Add(i.ToString()); }
            }
            return result;
        }
    }
}
