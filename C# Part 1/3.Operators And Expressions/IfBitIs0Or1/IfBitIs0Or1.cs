using System;

class IfBitIs0Or1
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int xAndMask = x & mask;
        int bit = xAndMask >> p;
        Console.Write("The number you have entered in bits is: ");
        Console.WriteLine(Convert.ToString(x,2));
        if (bit == 0)
        {
            Console.WriteLine("The bit at positing 3 is {0}",bit);
        }
        else
        {
            Console.WriteLine("The bit at position 3 is: 1");
        }
    }
}

