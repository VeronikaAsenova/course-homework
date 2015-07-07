using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
            {11, 12, 13, 14, 15},
            {21, 23, 22, 64, 18},
            {33, 45, 46, 54, 2}
        };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j] + "   ");
                    }
                   
                }
                Console.WriteLine();
                }
            }
        }



    }


