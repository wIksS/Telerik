//  Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Collections.Generic;

class AllVariations
{
    static int NumberOfLoops;
    static int NumberOfIterations;
    static int[] Loops;

    static void Main()
    {

        Console.Write("N:");
        NumberOfIterations = int.Parse(Console.ReadLine());

        Console.Write("K:");
        NumberOfLoops = int.Parse(Console.ReadLine());

        Loops = new int[NumberOfLoops];

        NestedLoops(0, 1);
    }

    static void NestedLoops(int CurrentLoop, int CurrentNumber)
    {
        if (CurrentLoop == NumberOfLoops)
        {
            PrintLoops();
        }
        else
        {
            for (int i = CurrentNumber; i <= NumberOfIterations; i++)
            {
                Loops[CurrentLoop] = i;
                NestedLoops(CurrentLoop + 1, i + 1);
            }
        }
    }

    static void PrintLoops()
    {
        for (int i = 0, counter = NumberOfLoops; i < NumberOfLoops;counter++, i++)
        {
            if (counter % NumberOfLoops == 0)
            {
                Console.Write("{");
            }
            Console.Write(" {0} ", Loops[i]);
            if (counter % NumberOfLoops == NumberOfLoops - 1)
            {
                Console.Write("}");
            }
        }
        Console.WriteLine();
    }
}