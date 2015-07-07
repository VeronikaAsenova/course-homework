using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which will be the part of an array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];


            Console.WriteLine("Enter {0} numbers to fill the array: ", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;

            foreach (int item in array)
            {
                if (n >= 2 && n <= 9)
                {
                    sum += item;
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            Console.WriteLine("The sum of all elements is: {0}", sum);
        }

    }
}
        
    
    
        



