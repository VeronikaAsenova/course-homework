using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_of_hm4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score:");
            int score = int.Parse(Console.ReadLine());

            if (score>1 && score<=3)
            {
                Console.WriteLine(score*5);

            }
          else if(score>4 && score<=6)
            {
                Console.WriteLine(score*10);
            }
            else if (score>7 && score<=9)
            {
                Console.WriteLine(score*50);
            }
        }

        

	}
	
		 
	}
    

