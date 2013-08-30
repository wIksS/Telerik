//  Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter the binary number : ");
        string binary = Console.ReadLine();
        int decimalNum = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1]-48 >1)
            {
                Console.WriteLine("Whrong input!");
                return;
            }
            decimalNum += (binary[binary.Length - i - 1]-48) * (int)Math.Pow(2, i);
        }
        Console.WriteLine(decimalNum);
    }
}

