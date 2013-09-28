//  * Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

using System;
using System.Collections.Generic;

class RemovingElements
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
        List<int> nums = new List<int>(array);
        for (int i = 0; i < size-1; i++)
        {
            if (nums[i]>nums[i+1])
            {
                nums.Remove(nums[i]);
                size--;
            }
            if (nums[i] > nums[i + 1])
            {
                nums.Remove(nums[i+1]);
                size--;
            }
        }        
        for (int i = 0; i <size; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}

