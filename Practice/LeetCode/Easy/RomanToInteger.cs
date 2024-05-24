using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class RomanToInteger
    {
        private Dictionary<string,int> RomanWithValues { get; set; }
        public RomanToInteger()
        {
            RomanWithValues = new Dictionary<string, int>();
            RomanWithValues.Add("I", 1);
            RomanWithValues.Add("V", 5);
            RomanWithValues.Add("X", 10);
            RomanWithValues.Add("L", 50);
            RomanWithValues.Add("C", 100);
            RomanWithValues.Add("D", 500);
            RomanWithValues.Add("M", 1000);
        }

        public int GetSum(string roman)
        {
            int sum = 0;
            char[] chars = roman.ToCharArray();
            for(int i = 0; i< chars.Length; i++)
            {
                // if current is greater than previous then fix the result
                if (i > 0 && RomanWithValues[chars[i].ToString()] > RomanWithValues[chars[i - 1].ToString()])
                {
                    // -2 for removing previously mistakely added value
                    sum += RomanWithValues[chars[i].ToString()] - 2 * RomanWithValues[chars[i - 1].ToString()];
                }
                else
                {
                    sum += RomanWithValues[chars[i].ToString()];
                }
            }
            return sum;
        }

    }
}
