using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value for z:");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value for x:");
            int x = int.Parse(Console.ReadLine());
            int result = (z % x);
            Console.WriteLine(result);

        }
    }
}
