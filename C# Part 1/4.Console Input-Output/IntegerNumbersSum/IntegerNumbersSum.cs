using System;

class IntegerNumbersSum
{
    static void Main()
    {
        Console.WriteLine("Insert first number :");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number :");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number :");
        int thirdNum = int.Parse(Console.ReadLine());
        int sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum of the numbers you have entered is : {0}",sum);
    }
}

