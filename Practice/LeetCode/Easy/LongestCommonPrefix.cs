using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class LongestCommonPrefix
    {

        public string Run(string[] strs)
        {
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                // Learn more about IndexOf (Here we are using for checking the prefix of current string with the prefix variable  )
                while (strs[i].IndexOf(prefix) != 0) //check if current string is not equal to prefix,
                {
                    //the while loop stops when the condition is 0. In this condition we get 0 when current string is equal to prefix
                    //so we keep removing the last prefix value to match with the current string
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }

    }
}
