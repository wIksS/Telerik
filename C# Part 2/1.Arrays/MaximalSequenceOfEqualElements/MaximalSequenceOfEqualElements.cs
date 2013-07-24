//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaximalSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            array[i] = int.Parse(Console.ReadLine());           //4eta masivyt ot konzolata
        }
        int counter = 1;  // I will use this to count the equal elements
        int max = 0;  // I will keep the max equal elements here
        int element = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i]==array[i+1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (max<counter)
            {
                max = counter;
                element = array[i];
            }
        }
        if (max==1)
        {
            Console.WriteLine("There is no sequence of equal elements");
            return;
        }
        Console.WriteLine("The maximum sequence of equal \"{1}\" elements is ---> {0}",max,element);
    }
}

