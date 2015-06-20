using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value for a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value for ha:");
            int ha = int.Parse(Console.ReadLine());

            Console.WriteLine(a * ha / 2.0);


        }
    }
}
