using System;

class IsThePointInTheCircle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if ((x > 5) && (y > 5))
        {
            Console.WriteLine("The coordinates you have entered are within the circle!g");
        }
        else
        {
            Console.WriteLine("The coordinates arent within the circle!");
        }
    }
}

