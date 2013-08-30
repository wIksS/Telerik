//  Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:

using System;

class DiffrenceBetweenTwoDates
{
    static void Main()
    {
        Console.Write("Enter the first date : ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second date : ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(firstDate);
        DateTime biggerDate = firstDate;
        DateTime smallerDate = secondDate;
        int days = 0;
        if (biggerDate.Year < secondDate.Year)
        {
            biggerDate = secondDate;
            smallerDate = firstDate;
        }
        else if (biggerDate.Month < secondDate.Month && biggerDate.Year == smallerDate.Year)
        {
            biggerDate = secondDate;
            smallerDate = firstDate;
        }
        else if (biggerDate.Day < secondDate.Day && biggerDate.Year == smallerDate.Year && biggerDate.Month == smallerDate.Month)
        {
            biggerDate = secondDate;
            smallerDate = firstDate;
        }
   while (true)
        {
            if (biggerDate.Year == smallerDate.Year && biggerDate.Month == smallerDate.Month && biggerDate.Day == smallerDate.Day)
            {
                break;
            }
            smallerDate = smallerDate.AddDays(1);
            days++;
     
        }
        Console.WriteLine(days);
        
    }
}

