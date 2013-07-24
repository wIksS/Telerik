//  * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubestOfKElements
{
    static void Main()
    {
        Console.Write("Enter enter the size of the array : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum : ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter how many elements should the sum be : ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            array[i] = int.Parse(Console.ReadLine());           //4eta masivyt ot konzolata
        }
        int combinations = (int)Math.Pow(2, n) - 1;
        int sum = 0;
        string binary = "";
        string subset = "";
        int counter = 0;
        for (int i = 0; i < combinations; i++)
        {           
            sum = 0;
            counter = 0;
            subset = "";
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sum += array[j];
                    subset += " " + array[j];
                    counter++;
                }
            }
            if (sum == s&&counter==k)
            {
                Console.WriteLine("A subest with {0} elements is : {1}", s, subset);
            }            
        }
    }
}

