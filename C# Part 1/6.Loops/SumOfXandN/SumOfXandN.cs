//  Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;
using System.Numerics;

class SumOfXandN
{
    static void Main()
    {
        Console.Write("X : ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("N : ");
        int n = int.Parse(Console.ReadLine());
        int sum = 1; // because it says 1 + 1!/X
        int iFact = 1;
        int i;
        int xMultiplyed = 1;
        for (i = 1; i <= n; i++)
        {
            for (int g = 1; g <= i; g++)
            {
                iFact *= g;
            }
            for (int j = 1; j <=i; j++)
            {
                xMultiplyed *= x;
            }
            sum += iFact / xMultiplyed;
            Console.Write("{0} + ",sum);
        }        
    }
}

