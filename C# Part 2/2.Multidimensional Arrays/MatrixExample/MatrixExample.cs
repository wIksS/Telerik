//  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class MatrixExample
{
    static void Main()
    {
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}",matrix[row,col],n);     // izpe4atvam matricata
            }
            Console.WriteLine();
        }
    }
}

