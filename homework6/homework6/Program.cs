using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a real value for a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter intiger for b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a / b);

        }
    }
}
