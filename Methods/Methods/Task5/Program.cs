using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            printSymetric();
        }
        private static void printSymetric()
        {
            for (int i = 10; i <=999; i++)
            {
                string num = i + "";
                char[] arr = num.ToCharArray();
                Array.Reverse(arr);
                String rev = new string(arr);

                if (num==rev)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
