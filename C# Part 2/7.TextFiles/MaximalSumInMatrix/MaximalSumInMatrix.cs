/* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2
* with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines
* contain N numbers separated by space. The output should be a single number in a separate text file. */

using System;
using System.IO;

class MaximalSumInMatrix
{
    static void Main()
    {
        int[,] matrix;
        int sizeOfTheMatrix;
        string[] matrixRows;
        string Row = string.Empty;

        StreamReader readLine;

        using (readLine = new StreamReader(@"..\..\input.txt"))
        {
            sizeOfTheMatrix = int.Parse(readLine.ReadLine());
            matrix = new int[sizeOfTheMatrix, sizeOfTheMatrix];
            matrixRows = new string[sizeOfTheMatrix];
            for (int i = 1; i <= sizeOfTheMatrix; i++)
            {
                Row = readLine.ReadLine();
                Row = Row.Trim('\t', ' ', '\n');
                matrixRows[i - 1] = Row;
            }
        }

        for (int i = 0; i < matrixRows.Length; i++)
        {
            string rowContain = matrixRows[i];
            for (int j = 0, n = 0; j < rowContain.Length; j++)
            {
                if (rowContain[j] != ' ')
                {
                    matrix[i, n] = int.Parse(rowContain[j].ToString());
                    n++;
                }
            }
        }

        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int temp = matrix[row, col] + matrix[row, (col + 1)] +
                    matrix[(row + 1), col] + matrix[(row + 1), (col + 1)];
                if (temp > maxSum)
                {
                    maxSum = temp;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}
