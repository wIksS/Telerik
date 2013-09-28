using System;

class BiggestOf3Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a>b)
        {
            if (a>c)
            {
                Console.WriteLine("The first number is the biggest");
            }
        }
        if (b>a)
        {
            if (b>c)
            {
                Console.WriteLine("The second number is the biggest");
            }
        }
        if (c>a)
        {
            if (c>b)
            {
                Console.WriteLine("The third number is the biggest");
            }
        }    
    }
}

