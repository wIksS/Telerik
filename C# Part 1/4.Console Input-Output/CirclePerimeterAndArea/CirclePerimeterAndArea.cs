using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Insert radius r =  ");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * pi * r;
        double area = r * r * pi;
        Console.WriteLine("The perimeter of the circle is : {0}",perimeter);
        Console.WriteLine("The area of the circle is : {0}",area);
    }
}

