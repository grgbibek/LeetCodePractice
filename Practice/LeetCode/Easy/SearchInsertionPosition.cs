using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class SearchInsertionPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int first = 0;
            int last = nums.Length - 1;
            int mid = 0;
            int index = 0;
            while (first <= last)
            {
                mid = (first + last) / 2;
                if (target < nums[mid])
                {
                    last = mid - 1;
                    index = last;
                }
                else if (target > nums[mid])
                {
                    first = mid + 1;
                    index = first;
                }
                else if (target == nums[mid])
                {
                    return mid;
                }
            }
            if(index < 0)
            {
                return 0;
            }else if(index >= nums.Length)
            {
                return nums.Length;
            }
            if ((index < nums.Length || index > 0) && target < nums[index])
            {
                return index;
            }
            return index + 1;
    }
    }
}
