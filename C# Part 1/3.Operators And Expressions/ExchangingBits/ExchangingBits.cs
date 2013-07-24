using System;

class ExchangingBits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int p1 = 3;
        int p2= 24;
        int numberAndMask=1;
        int mask=1;
        int bit=1;
        for (int i = 0; i < 3; p1++, p2++,i++)
        {
            mask = 1 << p1;
            numberAndMask = number & mask;
            bit = numberAndMask >> p1;
            if (bit == 1)
            {
                mask = 1 << p2;
                number = number | mask;

            }
            else if (bit == 0)
            {
                mask = ~(1 << p2);
                number = number & mask;
            }
        }
        Console.Write("The nuew number is : ");
        Console.WriteLine(number);
        Console.Write("The number in bits is : ");
        Console.WriteLine(Convert.ToString(number,2));
       // }
       
    }
}

