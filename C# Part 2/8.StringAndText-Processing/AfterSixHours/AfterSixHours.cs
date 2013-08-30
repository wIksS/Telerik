//  Write a program that reads a date and time given in the format: day.month.year 
//  hour:minute:second and prints the date and time after 6 hours and 30 minutes 
//  (in the same format) along with the day of week in Bulgarian.
using System;

class AfterSixHours
{
    static void Main()
    {
        Console.Write("Enter the time : ");
        DateTime time = DateTime.Parse(Console.ReadLine());
        time = time.AddHours(6);
        time = time.AddMinutes(30);
        Console.Write("After 6 h and 30 mins : ");
        Console.WriteLine(time);
    }
}

