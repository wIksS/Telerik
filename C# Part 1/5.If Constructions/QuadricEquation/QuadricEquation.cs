using System;

class QuadricEquation
{
    static void Main()
    {
        double x1,x2;
        double a =int.Parse(Console.ReadLine());
        double b =int.Parse(Console.ReadLine());
        double c =int.Parse(Console.ReadLine());
        double discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("The first root is : {0}\nThe second root is : {1}",x1,x2);
        }
        else if (discriminant == 0) 
        {
            x1 = x2 = -b / 2 * a;
            Console.WriteLine("The root to this equation is : {0}",x1);
        }
        else
        {
            Console.WriteLine("There arent any roots to this equation");
        }
    }
}

