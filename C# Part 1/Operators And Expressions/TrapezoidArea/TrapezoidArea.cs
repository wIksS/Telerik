using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Insert a : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert b :");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert h :");
        int h = int.Parse(Console.ReadLine());
        int area = ((a + b)*h) / 2;
        Console.WriteLine("The area of the trapezoid is : ");
        Console.WriteLine(area);
    }
}

