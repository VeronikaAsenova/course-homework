using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int[] fibonaci = new int[c];
            fibonaci[0] = 0;
            for (int i = 1, f = 1; i < c; i++)
            {
                fibonaci[i] = fibonaci[i] + f;
                f = fibonaci[i] + fibonaci[i - 1];
                Console.WriteLine(fibonaci[i]);
            }
        }
    }
}
