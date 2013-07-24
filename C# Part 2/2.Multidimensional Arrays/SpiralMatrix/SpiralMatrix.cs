//  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool right = false;
        bool down = true;
        bool up = false;
        bool left = false;
        int maxRotations = n*n;
        int col = 0;
        int row = 0;
        for (int i = 1; i <= maxRotations; i++)
        {
            if (down && (row==n || matrix[row,col]!=0))
            {
                row--;
                down = false;
                right = true;
                col++;
            }
            if (right && (col == n || matrix[row, col] != 0))
            {
                col--;
                right = false;
                up = true;
                row--;
            }
            if (up && (row < 0 || matrix[row, col] != 0))
            {
                row++;
                up = false;
                left = true;
                col--;
            }
            if (left && (col < 0 || matrix[row, col] != 0))
            {
                col++;
                left = false;
                down = true;
                row++;
            }
            matrix[row, col] = i;
            if (down)
            {
                row++;
            }
            if (right)
            {
                col++;
            }
            if (up)
            {
                row--;
            }
            if (left)
            {
                col--;
            }
            
        }
         for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                Console.Write("{0,3}", matrix[rows, cols], n);     // izpe4atvam matricata
            }
            Console.WriteLine();
        }
    }
}

