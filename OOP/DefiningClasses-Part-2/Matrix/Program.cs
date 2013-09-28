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
            Matrix<int> matrix = new Matrix<int>(25, 5);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = counter;
                    counter++;
                }
            }
            counter = 0;
            Matrix<int> matrix1 = new Matrix<int>(25, 5);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix1[i, j] = counter;
                    counter++;
                }
            }

            Matrix<int> newMatrix = matrix * matrix1;
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(newMatrix[i, j]);
                }
            }
        }
    }
}
