//  Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class BiggerThanNeighbors
{

    static bool isBiggerThanNeighbors(int[] array,int position)
    {
        bool isEqual = true;
        if (position>0)
        {
            if (array[position]<array[position-1])
            {
                isEqual = false;
            }
        }
        if (position < array.Length)
        {
            if (array[position] < array[position + 1])
            {
                isEqual = false;
            }
        }
        return isEqual;
    }



    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        Console.Write("Enter the wanted element position : ");
        int position = int.Parse(Console.ReadLine());
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter element number {0} : ",i);
            array[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The element is bigger than his neighbors -----> {0}",isBiggerThanNeighbors(array,position));
    }
}

