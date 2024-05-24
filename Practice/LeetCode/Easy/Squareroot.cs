using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class Squareroot
    {
        public long Run(long num)
        {
            long start = 0;
            long end = num;
            while(start + 1 < end)
            {
                long mid = (start + end) / 2;
                if((mid * mid) == num)
                {
                    return mid;
                }else if((mid * mid) < num)
                {
                    start = mid;
                }else if((mid * mid) > num)
                {
                    end = mid;
                }
            }
            if(end * end  == num)
            {
                return end;
            }
            return start;
        }
    }
}
