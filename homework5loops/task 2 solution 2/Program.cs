using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int i;
            i = 1;
            while (i <= 100)
            {
                if (i % 7 == 0 || i % 11 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}
    

