//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SortAnArray
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
        int min = 0;
        int temp = 0;
        for (int i = 0; i < size; i++)
        {
            min = i;
            for (int j = i+1; j < size; j++)
            {
                if (array[j]<array[min])
                {
                    min = j;
                }
            }
            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
            
        }
        Console.WriteLine("The new array is : ");
        for (int i = 0; i < size; i++)
        {
            if (i <= size - 2)
            {
                Console.Write("{0} , ", array[i]);
            }
            else
            {
                Console.Write("{0}",array[i]);
            }
        }
        Console.WriteLine();
    }
}

