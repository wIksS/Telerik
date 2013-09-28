//  Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;
using System.Collections;

class RepeatedNumInArray
{
    static int RepeatedNum(IEnumerable array, int num)
    {
        int counter = 0;
        foreach (int number in array)
        {
            if (number == num)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        Console.Write("Enter the wanted number : ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter element number {0} : ",i);
            array[i]=int.Parse(Console.ReadLine());
        }
        int times = RepeatedNum(array, num);
        Console.WriteLine("The number : {0} , appears {1} times in the array",num,times);
    }
}

