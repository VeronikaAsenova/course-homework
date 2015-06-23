using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int i;
    i = 1;
    do {
        if (i % 7 == 0 || i % 11 == 0) {
            Console.Write (i + " ");
        }
        i++;
    } while (i < 100);
    Console.WriteLine();
    }
   }
 }

