//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

using System;

class MaximalSumOfElements
{
    static void Main()
    {
        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K : ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] sumArray = new int[k]; // v tozi masiv shte slagam nai golemite elementi ot programata i sled tova shte gi sybera
        int temp = 0;
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (temp<array[i])
            {
                temp = array[i];
            }
        }
        sumArray[0] = temp;
        for (int i = 1; i < k; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (max<array[j]&&array[j]<temp)
                {
                    max = array[j];
                }  
            }
            sumArray[i] = max;
            if (max!=0)
            {
                temp = max;
            }
            max = 0;
        }
        int maxSum = 0;
        for (int i = 0; i < sumArray.Length; i++)
        {
            maxSum += sumArray[i];
        }
        Console.WriteLine("The maximum sum is ----> {0}",maxSum);
        
    }
}

