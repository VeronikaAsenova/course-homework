﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value of a:");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a value of b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a value of c:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Max: " + MaxNumber(MaxNumber (a, b), c));
        } 

        public static int MaxNumber (int a , int b)
        {
            if (a<b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
