//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class MostFrequentNumber
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
        int times = 1;
        int maxTimes = 0;
        int neededNum = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i!=j)
                {
                    if (array[i]==array[j])
                    {
                        times++;
                    } 
                }
            }
            if (times >maxTimes)
            {
                neededNum = array[i];
                maxTimes = times;
            }
            times = 0;
        }
        Console.WriteLine("The most frequend num is : {0} ({1} times)",neededNum,maxTimes);
    }
}

