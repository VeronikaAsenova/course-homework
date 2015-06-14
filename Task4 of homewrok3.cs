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
            float z = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value for x:");
            float x = float.Parse(Console.ReadLine());
            float result = (z / x);
            Console.WriteLine(result);

        }
    }
}
