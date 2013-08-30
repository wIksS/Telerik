//  Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//  Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

namespace WorkDays
{
    class WorkDays
    {
        static void Main()
        {
            Console.WriteLine("Enter which year is now : ");
            int nowYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter which month is now : ");
            int nowMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter which day is now : ");
            int nowDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year which workdays you want :");
            int holYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month which workdays you want : ");
            int holMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day of the month : ");
            int holDay = int.Parse(Console.ReadLine());
            DateTime nowTime = new DateTime(nowYear, nowMonth, nowDay);
            DateTime holydayTime = new DateTime(holYear, holMonth, holDay);
            int workDays = 0;
            int[] months = { 1, 1, 3, 5, 5, 5, 9, 9, 11, 12, 12, 12 };
            int[] days = { 1, 2, 3, 1, 6, 24, 6, 22, 1, 24, 25, 26 };
            while (true)
            {
                string dayOfWeek = nowTime.DayOfWeek.ToString();
                if (dayOfWeek!="Saturday" && dayOfWeek!="Sunday")
                {
                    bool isHolyday = true;
                    for (int i = 0; i < months.Length; i++)
                    {
                        if (months[i]==nowTime.Month && days[i]==nowTime.Day)
                        {
                            isHolyday = false;
                        }
                    }
                    if (isHolyday)
                    {
                        workDays++;
                    }
                }
                nowTime = nowTime.AddDays(1);
                if (nowTime.Year== holydayTime.Year && nowTime.Month==holydayTime.Month && nowTime.Day==holydayTime.Day)
                {
                    break;
                }
            }
            Console.WriteLine(workDays);

        }            
    }
}
