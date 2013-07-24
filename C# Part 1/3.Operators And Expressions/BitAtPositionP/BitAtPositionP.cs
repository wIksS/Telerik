using System;

class BitAtPositionP
{
    static void Main()
    {
        Console.WriteLine("Enter the position you want the bit to be : ");
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        Console.Write("The number in bits is : ");
        Console.WriteLine(Convert.ToString(v, 2));
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        Console.WriteLine(bit);
        if (bit == 0)
        {
            bool zero = false;
            Console.WriteLine(zero);
        }
        else
        {
            bool one = true;
            Console.WriteLine(one);
        }

    }
}

