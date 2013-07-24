//  We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//  Write a program that finds the longest sequence of equal strings in the matrix. Example:

using System;

class EqualStrings
{
    static void Main()
    {
        Console.Write("Enter the rows of the matrix : ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the cols of the matrix : ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Enter the element of the {0} row and {1} col : ",row,col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        Console.WriteLine("Your matrix is : ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }
        string element = "";
        int tempSequence = 1;
        int maxSequence = 0;
        int currow = 0;
        int curcol = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                curcol=col;
                currow=row;
                if (curcol < cols - 1 && currow < rows - 1)
                {
                    while (matrix[currow, curcol] == matrix[currow + 1, curcol + 1])
                    {
                        curcol++;
                        currow++;
                        tempSequence++;
                        if (tempSequence > maxSequence)
                        {
                            maxSequence = tempSequence;
                            element = matrix[row, col];
                        }
                        if (currow == rows - 1)
                        {
                            break;
                        }
                        if (curcol == cols - 1)
                        {
                            break;
                        }
                    }
                }
                tempSequence = 1;
                curcol = col;
                currow = row;
                if (currow < rows - 1)
                {
                    while (matrix[currow, curcol] == matrix[currow + 1, curcol])
                    {
                        currow++;
                        tempSequence++;
                        if (tempSequence > maxSequence)
                        {
                            maxSequence = tempSequence;
                            element = matrix[row, col];
                        }
                        if (currow == rows - 1)
                        {
                            break;
                        }
                    }
                }
                tempSequence = 1;
                curcol = col;
                currow = row;
                if (curcol < cols - 1)
                {
                    while (matrix[currow, curcol] == matrix[currow, curcol + 1])
                    {
                        curcol++;
                        tempSequence++;
                        if (tempSequence > maxSequence)
                        {
                            maxSequence = tempSequence;
                            element = matrix[row, col];
                        }
                        if (curcol == cols - 1)
                        {
                            break;
                        }
                    }
                }
                tempSequence = 1;
            }            
        }
        Console.WriteLine("The max sequence is : {0}", maxSequence);
        string[] array = new string[maxSequence];
        for (int i = 0; i < maxSequence; i++)
        {
            array[i] = element;                                 // tova e hityr na4in da otpe4atam elementa na konzolata kakto e v primera :)
        }                                                       // obshto vzeto pravq masiv s maxSequence elemnti i posle izpolzvam string.Join da gi na4ertaq
        Console.WriteLine(string.Join(",",array));
    }
}

