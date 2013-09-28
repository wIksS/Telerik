using System;

class ValueOfAGivenBit
{
    static void Main()
    {
        Console.WriteLine("Write the Integer :");
        int i = int.Parse(Console.ReadLine());
        Console.Write("The number in bits is : ");
        Console.WriteLine(Convert.ToString(i, 2));
        Console.WriteLine("The number of the bit :");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine("The value of the wanted bit is:");
        Console.WriteLine(bit);
    }
}

