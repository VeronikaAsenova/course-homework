using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_342
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ourArr = new int[n] {1,2,3,4,5};

            //for (int i = 0; i < ourArr.Length; i++)
           // {
                //ourArr[i] = int.Parse(Console.ReadLine());
           // }
            Console.WriteLine("==============");

            foreach (int item in ourArr )
            {
                Console.WriteLine(item);
            }
        }
        
    }
        
}
    

