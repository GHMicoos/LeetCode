using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Simple
{
    public partial class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> result = new List<int>();
            if (s == null || s.Length == 0)
            {
                return result;
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char item in p)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item,0);
                }
                dic[item]++;
            }
            Dictionary<char, int> have = null;
            for (int i = 0,ilen = s.Length; i < ilen; i++)
            {
                char item = s[i];
                if (dic.ContainsKey(item) && (s.Length-i)>=p.Length)
                {
                    have = new Dictionary<char, int>();
                    for (int j = i, jlen =i+ p.Length; j < jlen; j++)
                    {
                        char jitem = s[j];
                        if (!have.ContainsKey(jitem))
                        {
                            have.Add(jitem, 0);
                        }
                        have[jitem]++;
                    }
                    bool same = true;
                    foreach (char temp in dic.Keys)
                    {
                        if (!have.ContainsKey(temp) || have[temp]!=dic[temp])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same)
                    {
                        result.Add(i);
                    }
                }
            }



            return result;
        }
    }
}
