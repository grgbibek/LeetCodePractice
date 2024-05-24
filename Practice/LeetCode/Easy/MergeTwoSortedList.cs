using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class MergeTwoSortedList
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var temp_node = new ListNode(0);
            var current_node = temp_node;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current_node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current_node.next = list2;
                    list2 = list2.next;
                }
                //update the current node regardless
                current_node = current_node.next;
            }

            if(list1 != null)
            {
                current_node.next = list1;
            }
            if (list2 != null)
            {
                current_node.next = list2;
            }
            // skip the 1st node which is 0
            return temp_node.next;
        }
    }
}
