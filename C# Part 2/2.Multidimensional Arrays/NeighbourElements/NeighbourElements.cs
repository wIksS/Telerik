//* Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. Example:

using System;

class NeighbourElements
{
    static int number = 0;
    static int counter = 0;
    static int currentNumber = 0;
    static int[,] lab =
    {
        {1, 3, 3, 2, 3, 1, 3},
        {2, 2, 2, 2, 2, 2, 2},
        {3, 3, 3, 2, 3, 3, 1},
        {1, 2, 2, 2, 2, 2, 3},
        {3, 1, 3, 1, 3, 1, 1},
    };

    static void Exit(int row, int col)
    {
        if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
        {
            // we are out of the matrix, we can't find a sum
            return;
        }

        if (lab[row, col] == 0)
        {
            // the current cell is zero, we are not searching a sum
            return;
        }
        currentNumber = lab[row, col];
        // mark the current cell as visited
        lab[row, col] = 0;
        // recursion to explore all possible directions
        if (col - 1 >= 0 && lab[row, col - 1] == currentNumber)
        {
            Exit(row, col - 1); // left
        }
        if (row - 1 >= 0 && lab[row - 1, col] == currentNumber)
        {
            Exit(row - 1, col); // up
        }
        if (col + 1 < lab.GetLength(1) && lab[row, col + 1] == currentNumber)
        {
            Exit(row, col + 1); // right
        }
        if (row + 1 < lab.GetLength(0) && lab[row + 1, col] == currentNumber)
        {
            Exit(row + 1, col); // down
        }

        counter++;
        return;
    }

    static void Main()
    {
        int count = 0;
        int maxSequenceNumber = 0;

        for (int row = 0; row < lab.GetLength(0); row++)
        {
            for (int col = 0; col < lab.GetLength(1); col++)
            {
                if (lab[row, col] != 0)
                {
                    counter = 0;
                    number = lab[row, col];
                    bool checker = false;
                    Exit(row, col);
                    if (count < counter)
                    {
                        count = counter;
                        checker = true;
                        if (checker == true)
                        {
                            maxSequenceNumber = number;
                        }
                    }
                }
            }
        }
        Console.WriteLine("The largest area of equal neighbor elements is {0}", count);
        Console.WriteLine("The elements value is {0}", maxSequenceNumber);
    }
}