//  * We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;

class ASubsetOFSSum
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
        Console.Write("Insert the wanted sum : ");
        int s = int.Parse(Console.ReadLine());
        int combinations = (int)Math.Pow(2, size) - 1;
        int sum = 0;
        string subset = "";
        bool isSum = true;
        for (int i = 0; i < combinations; i++)
        {
            sum = 0;
            subset = "";
            for (int j = 0; j < size; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sum += array[j];
                    subset += " " + array[j];                    
                }                
            }
            if (sum == s)
            {
                Console.WriteLine("A subest with {0} elements is : {1}",s,subset);
                isSum = false;
            }
        }
        if (isSum)
        {
            Console.WriteLine("No");
        }
    }
}

