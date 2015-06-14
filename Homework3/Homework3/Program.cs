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
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value for ha:");
            float ha = float.Parse(Console.ReadLine());
            float result = (a * ha) / 2;
            Console.WriteLine(result);

        }
    }
}
