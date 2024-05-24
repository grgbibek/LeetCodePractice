using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class PlusOne
    {
        public int[] Run(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            
            int[] newInt = new int[digits.Length + 1];
            newInt[0] = 1;
            return newInt;

        }
    }
}
