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
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 || i % 11 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
            