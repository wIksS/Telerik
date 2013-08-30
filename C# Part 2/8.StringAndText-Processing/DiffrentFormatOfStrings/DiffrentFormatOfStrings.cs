//  Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//  percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class DiffrentFormatOfStrings
{
    static void Main()
    {
        Console.Write("Enter the number : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num.ToString("D"));
        Console.WriteLine(num.ToString("X"));
        Console.WriteLine(num.ToString("P"));

    }
}

