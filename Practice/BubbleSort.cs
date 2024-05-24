using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BubbleSort
    {
        public int[] Run(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //each time this loop is run the highest value is found
                //on the next iteration the founded highest value is ignored and second highest value is found and so on.
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
