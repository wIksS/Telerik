//  Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Text;

class FromSToDSystem
{
    static void Main()
    {
        Console.WriteLine("Enter S (numeral system): ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter D (numeral system): ");
        int d = int.Parse(Console.ReadLine());
        if (s<2 || d>16 || d<2 || s>16)
        {
            Console.WriteLine("Whrong input!!!");
            return;
        }
        Console.WriteLine("Enter the num in \"S\" numeral system : " );
        string num = Console.ReadLine();
        // Im going to make the S system to decimal and then the decimal to D system
        num = ConvertToDecimal(num,s);
        Console.WriteLine(Reverse(ConvertToDSystem(num,d)));
    }

    static string ConvertToDecimal(string num, int system)
    {
        int decimalNum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            decimalNum += (num[num.Length - i - 1] - 48) * (int)Math.Pow(system, i);
        }
        return decimalNum.ToString();
    }

    static string ConvertToDSystem(string num, int system)
    {
        int temp = int.Parse(num);
        StringBuilder dNum = new StringBuilder();
        while (temp > 0)
        {
            if (temp % system > 9)
            {
                char nums = (char)(65 + ((temp % system) % 10));
                dNum.Append(nums.ToString());
            }
            else
            {
                dNum.Append((temp % system).ToString());
            }
            temp /= system;
        }
        return dNum.ToString();
    }

    public static string Reverse(string hecNum)
    {
        char[] charArray = hecNum.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }    
}

