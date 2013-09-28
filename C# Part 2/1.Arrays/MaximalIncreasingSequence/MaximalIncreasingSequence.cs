//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;  // I will use this to count the equal elements
        int max = 0;  // I will keep the max equal elements here
        bool isStart = true;
        int tempStart = 0;
        int tempEnd = 0;
        bool restart = true;
        for (int i = 0; i < lenght-1; i++)
        {
            if (array[i]+1==array[i+1])
            {
                if (restart)
                {
                    tempEnd = 0;
                    tempStart = 0;
                    restart = false;
                }
                if (isStart)
                {
                    tempStart = i;
                    isStart = false;
                }
                tempEnd = i+1;
                counter++;      //I check if the next element is a sequence
            }
            else
            {
                restart = true;
                isStart = true;
                counter = 1;
            }
            if (max<counter)
            {
                max = counter;
            }
        }
        Console.WriteLine("The maximum sequence of increasing elements is ---> {0}", max);
        Console.Write("The elements are : ");
        for (int i =tempStart; i < tempEnd+1; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
    }
}

