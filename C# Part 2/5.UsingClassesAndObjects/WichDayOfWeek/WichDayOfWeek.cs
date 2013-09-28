//  Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

namespace WichDayOfWeek
{
    class WichDayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("The day of the week is : {0}",today.DayOfWeek);
        }        
    }
}

