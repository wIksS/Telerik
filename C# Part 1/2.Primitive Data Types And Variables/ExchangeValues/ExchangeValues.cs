using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

