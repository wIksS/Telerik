//  Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers 
//  from the console and prints the biggest of them using the method GetMax().

using System;
using System.Collections.Generic;

class Get
{
    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum>secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }
    static void Main()
    {
        Console.Write("Enter the first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number : ");
        int thirdNum = int.Parse(Console.ReadLine());
        int maxOfTwo = GetMax(firstNum,secondNum);
        int biggestNum = GetMax(maxOfTwo, thirdNum);
        Console.WriteLine("The biggest number is {0}",biggestNum);
    }
}

