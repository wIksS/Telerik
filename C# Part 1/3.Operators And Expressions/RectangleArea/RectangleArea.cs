using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Insert the \"width\" of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Insert the \"height\" of the rectangle: ");
        float height = float.Parse(Console.ReadLine());
        float rectangleArea = width * height;
        Console.WriteLine("The area of the rectangle is: {0}",rectangleArea);
    }
}

