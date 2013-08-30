//  Write a program to convert hexadecimal numbers to their decimal representation.


using System;
using System.Text;

class HecToDec
{
    static void Main()
    {
        Console.Write("Enter the hexademical number : ");
        string hexademical = Console.ReadLine();
        int decimalNum = 0;
        for (int i = 0; i < hexademical.Length; i++)
        {
            if (hexademical[hexademical.Length - i - 1] - 65 > 5)
            {
                Console.WriteLine("Whrong input!");
                return;
            }
            if (hexademical[hexademical.Length - i - 1]>= 65)
            {
                decimalNum += (hexademical[hexademical.Length - i - 1] - 65 + 10) * (int)Math.Pow(16, i);
            }
            else
            {
                decimalNum += (hexademical[hexademical.Length - i - 1] - 48) * (int)Math.Pow(16, i);
            }
        }
        Console.WriteLine(decimalNum);
    }
}

