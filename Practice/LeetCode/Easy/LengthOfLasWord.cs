using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class LengthOfLasWord
    {
        public int Run(string s)
        {
            string[] strArray = s.Split(" ");
            int skipLast = 1;
            while (strArray[strArray.Length - skipLast] == String.Empty)
            {
                skipLast++;
            }
            return strArray[strArray.Length - skipLast].Length;

        }
    }
}
