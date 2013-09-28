//Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            array[i] = int.Parse(Console.ReadLine());           //4eta masivyt ot konzolata
        }
        Console.Write("Enter the needed sum : ");
        int neededSum = int.Parse(Console.ReadLine());
        int sum = 0;
        int start = 0;
        int sequence = 0;
        bool isSum = false;
        for (int i = 0; i < size; i++)
        {
            for (int j = i; j < size; j++)
            {
                sum += array[j];
                if (sum==neededSum)
                {
                    start = i;
                    sequence = j - i;
                    isSum = true;
                }
            }
            sum = 0;
        }
        Console.WriteLine("The needed sum is present in the array ----> {0}",isSum);
        Console.Write("The elements are : ");
        for (int i = start; i < start+sequence+1; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
    }
}

