//  Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;

class DecToHec
{
    static void Main()
    {
        Console.Write("Enter the decimal number : ");
        int decimalNum = int.Parse(Console.ReadLine());
        StringBuilder hecNum = new StringBuilder();
        int temp = decimalNum;

        while (temp > 0)
        {
            if (temp % 16 > 9)
            {
                char num = (char)(65+((temp%16)%10));
                hecNum.Append(num.ToString());
            }
            else
            {
                hecNum.Append((temp % 16).ToString());
            }
            temp /= 16;
        }
        Console.WriteLine("Decimal : {0}",decimalNum);
        Console.WriteLine("Hexademical : {0}",Reverse(hecNum));
    }

    // I will use this method to reverse the string

    public static string Reverse(StringBuilder hecNum)
    {
        char[] charArray = hecNum.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

