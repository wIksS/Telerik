//  Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSorting
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());
        string[] stringArr = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            stringArr[i] = Console.ReadLine();           //4eta masivyt ot konzolata            
        }
        QuickSort(stringArr, 0, stringArr.Length - 1);

        for (int i = 0; i < stringArr.Length; i++)
        {
            Console.Write(stringArr[i] + " ");
        }
        Console.WriteLine();
    }

    static int Partition(string[] stringArr, int p, int r)
    {
        string x = stringArr[r];
        int i = p - 1;
        string temp = "";
        for (int j = p; j < r; j++)
        {
            if (string.Compare(stringArr[j], x) < 0)
            {
                i = i + 1;
                temp = stringArr[i];
                stringArr[i] = stringArr[j];
                stringArr[j] = temp;
            }
        }
        temp = stringArr[i + 1];
        stringArr[i + 1] = stringArr[r];
        stringArr[r] = temp;

        return i + 1;
    }

    static void QuickSort(string[] stringArr, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(stringArr, p, r);
            QuickSort(stringArr, p, q - 1);
            QuickSort(stringArr, q + 1, r);
        }
    }
}