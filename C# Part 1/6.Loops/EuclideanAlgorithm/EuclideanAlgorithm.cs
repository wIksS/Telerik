//  Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Insert first num : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Insert second num : ");
        int secondNum = int.Parse(Console.ReadLine());
        int remainder;
        do
        {
            remainder = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = remainder;
        } while (remainder != 0) ;
        Console.WriteLine(firstNum);

    }
}

