using System;

class MergeSort
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the № {0} element : ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());           //4eta masivyt ot konzolata            
        }
        int[] temp = new int[numbers.Length];
        System.Console.WriteLine("Before sorting: {0}", string.Join(" ", numbers));
        MergeSort(numbers, temp, 0, numbers.Length - 1);
        System.Console.WriteLine("After sorting: {0}", string.Join(" ", numbers));
    }

    static void MergeSort(int[] array, int[] tmp, int start, int end)
    {
        if (start >= end) return;
        int middle = start + (end - start) / 2;
        MergeSort(array, tmp, start, middle);
        MergeSort(array, tmp, middle + 1, end);
        CompareAndSort(array, tmp, start, middle, end);
    }

    static void CompareAndSort(int[] array, int[] tmp, int start, int middle, int end)
    {
        int left_tmp = start, left_arr = start, middle_arr = middle + 1;

        while (left_arr <= middle && middle_arr <= end)
        {
            if (array[left_arr] > array[middle_arr])
            {
                tmp[left_tmp++] = array[middle_arr++];
            }
            else
            {
                tmp[left_tmp++] = array[left_arr++];
            }
        }

        while (left_arr <= middle)
            tmp[left_tmp++] = array[left_arr++];

        while (middle_arr <= end)
            tmp[left_tmp++] = array[middle_arr++];

        for (int i = start; i <= end; i++)
            array[i] = tmp[i];
    }
}

