using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value of a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a  value of b:");
            int b = int.Parse(Console.ReadLine());

            if (a>=b)
            {
                Console.WriteLine("b must be bigger than a");
                return;
            }
            for (; a <= b; a++)

                if (a % 3==0)
                {
                    Console.WriteLine(a);
                }
            {
                
            }
        }
    }
}

