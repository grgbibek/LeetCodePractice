using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.Easy
{
    public class AverageSalary
    {
        public double Run(int[] salary)
        {
            int min_salary = salary.Min();
            int max_salary = salary.Max();
            int sum_salary = salary.Sum() - min_salary - max_salary;
            int r = salary.Length - 2;
            return sum_salary / r;
            
            //BubbleSort bubbleSort = new BubbleSort();
            //salary = bubbleSort.Run(salary);
            //int count = 0; 
            //int sum = 0;
            //for (int i = 1; i < salary.Length - 1; i++)
            //{
            //    sum += salary[i];
            //    count++;
            //}
            //return (int) (sum / count);
        }
    }
}
