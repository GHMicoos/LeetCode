using LeetCodeProblem.Simple;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            s.FindAnagrams("cbaebabacd","abc");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
