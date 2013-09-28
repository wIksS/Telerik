//  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class MatrixExampleC
{
    static void Main()
    {
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int combinations = n * n;
        int nums = 1;
        int row = n-1;
        int col = 0;
        int counter = 2;
        int counter1 = 1;
        bool isRow = true;
        while (nums <= combinations)
        {
            while (true)
            {
                if (row == n&&isRow)
                {
                    row = n - counter;
                    col = 0;
                    counter++;
                    if (counter==n+1)
                    {
                        isRow = false;
                    }
                    break;
                }
                if (col==n)
                {
                    row = 0;
                    col = counter1;
                    counter1++;
                    break;
                }
                matrix[row, col] = nums;
                nums++;
                row++;
                col++;
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