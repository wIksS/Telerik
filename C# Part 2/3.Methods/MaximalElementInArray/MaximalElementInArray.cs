//  Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

using System;

class MaximalElementInArray
{
    public static int maxIndex = 0;

    static void Main()
    {
        Console.Write("Enter the beggining of the portion : ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of the portion : ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Enter the lenght of the array : ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter element number {0} : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The maximal number is : \"{0}\" , on position {1}",MaximalNumber(array,start,end),maxIndex);
        Console.WriteLine("For ascending sort write \"a\" ");
        Console.WriteLine("For decsending sort write \"d\" ");
        Console.Write("What do you want : ");
        string choice = Console.ReadLine();
        if (choice == "a")
        {
            AscendingSort(array);
            Console.WriteLine("The new array is : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " " );
            }
        }
        if (choice == "d")
        {
            Console.WriteLine("The new array is : ");
            DescendingSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        Console.WriteLine();
    }

    static int MaximalNumber(int[] array, int start, int end)
    {
        int max = int.MinValue;
        for (int i = start; i <= end; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        return max;
    }

    static void AscendingSort(int[] array)
    {
        int temp = 0;
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    temp = j;
                }
            }
            array[temp] = array[i];
            array[i] = min;
            min = int.MaxValue;
        }
    }
    static void DescendingSort(int[] array)
    {
        int temp = 0;
        int min = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] > min)
                {
                    min = array[j];
                    temp = j;
                }
            }
            array[temp] = array[i];
            array[i] = min;
            min = int.MinValue;
        }
    }
}

