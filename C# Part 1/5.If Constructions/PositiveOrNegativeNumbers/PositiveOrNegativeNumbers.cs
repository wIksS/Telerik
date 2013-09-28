using System;

class PositiveOrNegativeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if ((a > 0) && (b > 0) && (c > 0))
        {
            Console.WriteLine("The produc will be : +");
        }
        else if ((a < 0) && (b < 0) && (c > 0))
        {
            Console.WriteLine("The product will be : +");
        }
        else if ((a < 0) && (c < 0) && (b > 0))
        {
            Console.WriteLine("The product will be : +");
        }
        else if ((a > 0) && (c < 0) && (b < 0)) 
        {
            Console.WriteLine("The product will be : +");
        }
        else
        {
            Console.WriteLine("The product is : -");
        }
    }
}

