using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class RemoveDuplicates
    {
        public int Run(int[] nums)
        {
            int c = 0;
            if (nums.Length > 0)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[c] != nums[i])
                    {
                        nums[++c] = nums[i];
                    }
                }
            }
            return c + 1;
        }
    }
}
