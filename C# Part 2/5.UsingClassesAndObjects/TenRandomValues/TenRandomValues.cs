//  Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

namespace TenRandomValues
{
    class TenRandomValues
    {
        static void Main()
        {
            Random randomNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNum.Next(100,201));
            }
            // the max value is 201 because Random works like this (minValue,maxValue] 
            //so it was 200 it would go only to 199 and we would have missed 200
        }
    }
}
