//  Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            DateTime enteredYear = new DateTime(year, 1, 1);
            if (DateTime.IsLeapYear(enteredYear.Year))
            {
                Console.WriteLine("{0} is leap year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap  year !!!",year);
            }
            
        }
    }
}
