using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text == "Hello")
            {
                Console.WriteLine("String equals Hello");
            }
            else
            {
                Console.WriteLine("String is not equal to Hello");
            }
        }
    }
}
