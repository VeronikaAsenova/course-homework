using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 12, 14, 20, 17, 7, 5, 9, 3, 33, 88 };
            int sum=0;

            for (int i = 0; i < a.Length; i++)
                          
           {
               if (a[i] % 2 == 0)
                   sum += a[i];
            }
            Console.WriteLine("sum is " + sum);
        }
    }
}
