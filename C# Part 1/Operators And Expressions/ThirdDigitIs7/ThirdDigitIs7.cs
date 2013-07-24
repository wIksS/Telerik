using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        x = x / 100;
        x = x % 10;
        bool is7 = true;
        Console.Write("The third digit is 7 : ");
        if (x==7)
        {
            Console.WriteLine(is7);
        }
        else
        {
            is7 = false;
            Console.WriteLine(is7);
        }
    }
}

