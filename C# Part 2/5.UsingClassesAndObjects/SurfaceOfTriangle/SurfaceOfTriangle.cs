//  Write methods that calculate the surface of a triangle by given:
//  Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

namespace SurfaceOfTriangle
{
    class SurfaceOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter what do you want (1, 2 or 3)");
            Console.WriteLine("1 : Side and Altitude");
            Console.WriteLine("2 : Three sides");
            Console.WriteLine("3 : Two sides and an angle between them");
            Console.Write("Your option : ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("Enter Side : ");
                int side = int.Parse(Console.ReadLine());
                Console.Write("Enter the altitude : ");
                int altitude = int.Parse(Console.ReadLine());
                Console.WriteLine("The area is {0}",AreaBySideAndAltitude(side,altitude));
            }
            else if (option == 2)
            {
                Console.Write("Enter side 1 : ");
                int sideOne = int.Parse(Console.ReadLine());
                Console.Write("Enter side 2 : ");
                int sideTwo = int.Parse(Console.ReadLine());
                Console.Write("Enter side 3 : ");
                int sideThree = int.Parse(Console.ReadLine());
                // I m going to use the Heron's formula to solve this
                Console.WriteLine("The area is : {0}",AreaByThreeSides(sideOne,sideTwo,sideThree));
            }
            else
            {
                Console.Write("Enter side 1 : ");
                int sideOne = int.Parse(Console.ReadLine());
                Console.Write("Enter side 2 : ");
                int sideTwo = int.Parse(Console.ReadLine());
                Console.Write("Enter angle : ");
                int angle = int.Parse(Console.ReadLine());
                Console.WriteLine("The area is : {0}", AreaByTwoSidesAndAngle(sideOne,sideTwo,angle));
            }
        }

        static double AreaByTwoSidesAndAngle(int sideOne, int sideTwo, int angle)
        {
            double radiandAngle = angle*(Math.PI/180);
            double sinusOfAngle = Math.Sin(radiandAngle);
            double area = (sideOne*sideTwo*sinusOfAngle)/2;
            return area;
        }

        static int AreaBySideAndAltitude(int side, int altitude)
        {
            int area = (side * altitude) / 2;
            return area;
        }

        static double AreaByThreeSides(int sideOne, int sideTwo, int sideThree)
        {
            double p = (sideOne + sideTwo + sideThree) / 2.0;
            double area = Math.Sqrt(p * ((p - sideOne) * (p - sideTwo) * (p - sideThree)));
            return area;
        }
    }
}
