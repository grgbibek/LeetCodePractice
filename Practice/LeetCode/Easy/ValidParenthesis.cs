using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            char[] charArray = s.ToCharArray();
            string temp = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
                {
                    temp += charArray[i];
                }
                else if (charArray[i] == ')' || charArray[i] == '}' || charArray[i] == ']')
                {
                    if (temp.Length == 0) return false;
                    var lastChar = temp.Substring(temp.Length - 1, 1);
                    if ((lastChar == "(" && charArray[i] == ')') || (lastChar == "{" && charArray[i] == '}') || (lastChar == "[" && charArray[i] == ']'))
                    {
                        temp = temp.Remove(temp.Length - 1, 1);
                    }
                    else
                    {
                        temp += charArray[i];
                    }
                }
                else { return false; }
            }
            return string.IsNullOrEmpty(temp) ? true : false;
        }
    }
}
