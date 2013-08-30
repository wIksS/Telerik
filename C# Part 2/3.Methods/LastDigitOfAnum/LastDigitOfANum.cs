//  Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigitOfANum
{
    static string LastDigit(int num)
    {
        string[] numbers = new string[9] { "zero", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int last = num % 10-1;
        return numbers[last];
    }
    static void Main()
    {
        Console.Write("Enter the integer : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(num));
    }
}

