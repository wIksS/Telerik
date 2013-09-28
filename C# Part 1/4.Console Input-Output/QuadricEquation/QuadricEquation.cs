using System;

class QuadricEquation
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double x1, x2;
        double discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("The first root is x1 = {0}\nThe second root is x2 = {1}",x1,x2);
        }
        if (discriminant==0)
        {
            x1 = x2 = x1 = -b / 2 * a;
            Console.WriteLine("x1 = x2 = {0}",x1);
        }
        else if (discriminant<0)
        {
            Console.WriteLine("There are no real roots for this equation");
        }
    }
}

