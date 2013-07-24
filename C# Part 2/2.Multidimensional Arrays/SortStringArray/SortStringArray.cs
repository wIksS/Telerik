//  You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortStringArray
{    
    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0} : ", i);
            array[i] =Console.ReadLine();   //I m reading the array from the console
        }
        int temp = 0;
        int min = int.MaxValue;
        int tempMin = 0;
        string tempStr = "";
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (array[j].Length < min && array[j].Length >= tempMin) 
                {
                    min = array[j].Length;
                    temp = j;
                }
            }
            tempStr = array[i];
            array[i] = array[temp];
            array[temp] = tempStr;
            tempMin = min;
            min = int.MaxValue;
        }
        Console.WriteLine(string.Join(",",array));
    }
}

