//  Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSumInASquare
{
    static void Main()
    {
        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M : ");
        int m = int.Parse(Console.ReadLine());
        int sum = 0;
        int maxSum = int.MinValue;
        n = 3;      
        m = 6;      // pravq nqkakyv slu4aen primer za da nqma nujda vseki pyt da se 4ete cqlata matrica
        int[,] matrix = {
         {7,1,3,5,7,23,},
         {1,26,74,2,4,1,},
         {4,7,6,9,1,1},
         {4,7,6,9,1,1}

        };
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1]
                    + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col + 2];
                if (sum>maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine("The maximal sum in a 3 x 3 square is : {0}",maxSum);
    }
}

