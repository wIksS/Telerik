using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Matrix<double> matrix = new Matrix<double>(1, 3);
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0},{1}]", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                    counter++;
                }
            }
            counter = 0;
            Matrix<double> matrix1 = new Matrix<double>(3, 2);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("[{0},{1}]",i,j);
                    matrix1[i, j] = double.Parse(Console.ReadLine());
                    counter++;
                }
            }

            Matrix<double> newMatrix = matrix * matrix1;
            Console.WriteLine("\n");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
