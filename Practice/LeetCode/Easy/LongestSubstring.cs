using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class LongestSubstring
    {

        public int Run(string s)
        {
            List<char> c = new List<char>();
            int iPointer = 0;
            int jpointer = 0;
            int max = 0;
            while (jpointer < s.Length)
            {
                if (c.Contains(s[jpointer]))
                {
                    c.Remove(s[iPointer]);
                    iPointer++;
                }
                else
                {
                    max = Math.Max(c.Count(), max);
                    c.Add(s[jpointer]);
                    jpointer++;
                }
            }
            return max;
        }

    }
}
