//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class IndexOfAnElement
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
        Console.Write("Enter the wanted element : ");
        int neededNum = int.Parse(Console.ReadLine());
        int currNum = 0;
        int counter1 = 0;
        int counter = 2;            // s tova shte znam kolko pyti sym razdelil goleminata na masivyt
        do
        {
            if (neededNum==size/counter)
            {
                break;
            }
            if (neededNum>array[size/counter])
            {
                counter1++;
                if (neededNum==array[counter1+size/counter])
                {
                    break;
                }
            }
            else
            {
                counter += 2;
            }
        } while (currNum!=neededNum);
        Console.WriteLine("The index of the wanted element is : {0}",counter1+size/counter);
        
    }
}

