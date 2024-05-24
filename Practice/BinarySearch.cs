using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BinarySearch
    {
        public BinarySearch(int[] intArray)
        {
            IntArray = intArray;
            Start = 0;
            End = intArray.Length - 1;
        }
        private int[] IntArray{ get; set; }
        private int Start { get; set; }
        private int End { get; set; }
        private int Middle { get; set; }
        
        public int? Find(int search)
        {
            while (Start <= End)
            {
                Middle = (Start + End) / 2;

                if (search > IntArray[Middle])
                {
                    Start = Middle + 1;
                }
                else if (search < IntArray[Middle])
                {
                    End = Middle - 1;
                }
                else if (IntArray[Middle] == search)
                {
                    return Middle;
                }
            }
            return null;
        }
    }
}
