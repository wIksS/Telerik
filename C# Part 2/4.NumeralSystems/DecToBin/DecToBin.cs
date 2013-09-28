//  Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter the decimal number : ");
        int decimalNum = int.Parse(Console.ReadLine());
        StringBuilder binaryNum = new StringBuilder();
        int temp = decimalNum;

        while (temp>0)
        {
            binaryNum.Append((temp % 2).ToString());
            temp /= 2;
        }
        Console.WriteLine("Decimal : {0}",decimalNum);
        Console.WriteLine("Binary : {0}",Reverse(binaryNum));
    }

    // I will use this method to reverse the string

    public static string Reverse(StringBuilder binaryNum)
    {
        char[] charArray = binaryNum.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

