using System;

class WithinCircleAndOutRectangle
{
    static void Main()
    {
        float x = -1.1f;//float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float x1 = 1.1f;
        float y1 = 3;
        float x2 = -1.1f;
        float y2 = -3;
        float y3 = 1;
        float y4 = -1;
        float x3 = 5;
        float x4 = -1;
        if ((x <= x1) && (x >= x2) && (y <= y1) && (y >= y2))
        {
            if (((y > y3) ^ (y < -1)) && ((x >= 5) ^ (x <= -1)))
            {
                Console.WriteLine("The point is in the circle and outside the rectangle !");
            }
        }
    }
}

