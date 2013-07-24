//  Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class AllVariations
{
    static int NumberOfLoops;
    static int NumberOfIterations;
    static int[] Loops;

    static void Main(string[] args)
    {

        Console.Write("Enter N :");
        NumberOfIterations = int.Parse(Console.ReadLine());

        Console.Write("Enter K :");
        NumberOfLoops = int.Parse(Console.ReadLine());

        Loops = new int[NumberOfLoops];

        NestedLoops(0);
    }

    static void NestedLoops(int CurrentLoop)
    {
        if (CurrentLoop == NumberOfLoops)
        {
            PrintLoops();
            return;
        }
        for (int i = 1; i <= NumberOfIterations; i++)
        {
            Loops[CurrentLoop] = i;
            NestedLoops(CurrentLoop + 1);
        }
    }

    static void PrintLoops()
    {
        for (int i = 0, counter = NumberOfLoops; i < NumberOfLoops; i++, counter++)
        {
            if (counter%NumberOfLoops==0)
            {
                Console.Write("{");
            }
            Console.Write(" {0} ", Loops[i]);
            if (counter % NumberOfLoops == NumberOfLoops-1)
            {
                Console.Write("}");
            }
        }
        Console.WriteLine();
    }
}