//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSumInArray
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
        int currSum = array[0];
        int currSequence = 1;
        int maxSequence = 1;
        int start = 0;
        int max = 0;
        int startTemp = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i]+currSum >array[i])
            {
                currSum += array[i];
                currSequence++;
            }
            else
            {
                currSum = array[i];
                startTemp = i;
                currSequence = 1;
            }
            if (currSum>max)
            {
                max = currSum;
                start = startTemp;
                maxSequence = currSequence;
            }
        }
        Console.WriteLine("The sum is : {0}",max);
        for (int i = start; i < start+maxSequence; i++)
        {
            Console.WriteLine(array[i] + " ");
        }
    }
}



