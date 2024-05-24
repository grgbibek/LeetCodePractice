using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class ClimbingStairs
    {
        //Fibonacci sequence logic
        public int Run(int n)
        {
            int[] arrayNum = new int[n + 1];
            arrayNum[0] = 1;
            arrayNum[1] = 1;
            for(int i = 2; i <= n; i++)
            {
                arrayNum[i] = arrayNum[i - 2] + arrayNum[i - 1];
            }
            return arrayNum[n];
        }
    }
}
