using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] y = { 3, 5, 7, 1, 11, 25, 64, 25, 33, 11, 57 };

                int number = 11;
                for (int i = 0; i < y.Length; i++)
                {
                    if (y[i] == number)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
