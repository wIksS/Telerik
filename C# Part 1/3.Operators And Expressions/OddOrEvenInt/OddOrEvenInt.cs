using System;

class OddOrEvenInt
{
    static void Main()
    {
        Console.WriteLine("Insert a number:");
        int someInt = int.Parse(Console.ReadLine());
        if ((someInt % 2) == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

