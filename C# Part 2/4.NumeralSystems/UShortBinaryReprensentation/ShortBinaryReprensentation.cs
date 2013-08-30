//  Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class ShortBinaryReprensentation
{
    static void Main()
    {
        Console.WriteLine("Enter the number : ");
        short num = short.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num,2).PadLeft(16,'0'));
    }
}

