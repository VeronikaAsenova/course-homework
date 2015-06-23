using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter a num for n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a num for k");
                int k = int.Parse(Console.ReadLine());
    Console.WriteLine ("N!/K! = " + factorial(n) / factorial(k));
}
        }
private static int factorial(int num) {
    int factorial = num--;
    for ( ; num >= 1; num--) {
        factorial *= num;
    }
    return factorial;
}
        }
    }




