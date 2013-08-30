//  Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//  Use the method from the previous exercise.

using System;

class BiggerThanNeighbors
{

    static bool isBiggerThanNeighbors(int[] array, int position)
    {
        bool isEqual = true;
        if (position > 0)
        {
            if (array[position] < array[position - 1])
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
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter element number {0} : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length-1; i++)
        {
            bool firstEqual = isBiggerThanNeighbors(array, i);
            if (firstEqual)
            {
                Console.WriteLine("The first element with equal neighbors is {0} , on position {1}",array[i],i);
                return;
            }
        }
        Console.WriteLine("There is no such number");
    }
}

