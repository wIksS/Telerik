//  Write a method that reverses the digits of given decimal number. Example: 256  652

using System;
using System.Text;

class ReversingDigits
{
    static decimal ReverseDigits(decimal num)
    {
        int dot = 0;
        StringBuilder number = new StringBuilder(num.ToString());
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i]=='.')
            {
                number = number.Remove(i, 1);
                dot = i;
            }
            if (number[i] == '-')
            {
                number = number.Remove(i, 1);
            }
        }
        for (int i = 0; i < number.Length/2;i++)
        {
            char temp = number[i];
            number[i] = number[number.Length-i-1];
            number[number.Length - i-1] = temp;
        }
        number = number.Insert(dot, '.');
        return decimal.Parse(number.ToString());
    }

    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";

        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        // I m doing this to change my decimal point from comma "," to dot "."
        Console.Write("Enter the decimal number : ");
        decimal num = decimal.Parse(Console.ReadLine());
        bool isPositive = num > 0;
        if (isPositive)
        {
            Console.WriteLine(ReverseDigits(num));
        }
        else
        {
            Console.WriteLine("-"+ReverseDigits(num));
        }
    }
}

