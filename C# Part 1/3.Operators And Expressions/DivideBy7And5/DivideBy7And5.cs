using System;

class DivideBy7And5
{
    static void Main()
    {
        int someInt = int.Parse(Console.ReadLine());
        if (((someInt%5)==0)&&((someInt%7)==0))
        {
            Console.WriteLine("The number can be divided by 5 and 7 at the same time");
        }
        else
        {
            Console.WriteLine("The number cant be divided by 5 and 7!");
        }
    }
}

