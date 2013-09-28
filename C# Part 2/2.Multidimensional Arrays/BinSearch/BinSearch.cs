//  Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinSearch
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K : ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0} : ",i);
            array[i] = int.Parse(Console.ReadLine());   //I m reading the array from the console
        }
        Array.Sort(array);
        Console.Write("The sorted array is : ");
        Console.WriteLine(string.Join(",",array));
        int position = Array.BinarySearch(array,k);
        if (position==-1)
        {
            Console.WriteLine("No such number");
            return;
        }
        if (position<0)
        {
            Console.WriteLine("The largest number smaller than {0} in the array is : {1}",k,array[position*-1-2]);
            return;
        }
        else if (position>0)
        {               
             Console.WriteLine("The largest number smaller than {0} in the array is : {1}",k,array[position-1]);
        }        
    }
}

