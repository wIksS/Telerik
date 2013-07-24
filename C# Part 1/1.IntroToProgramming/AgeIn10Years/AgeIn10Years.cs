using System;

class AgeIn10Years
{
    static void Main()
    {
        Console.WriteLine("Enter the year when you were born :");
        int bornYear = int.Parse(Console.ReadLine());
        int currentYear=DateTime.Now.Year;
        int ageNow, futureAge;
        if ((bornYear>=1900)&&(bornYear<currentYear))
        {
            ageNow = currentYear - bornYear;
            futureAge = ageNow + 10;
            Console.WriteLine("Your age now is {0}, but your age in 10 years will be {1}",ageNow,futureAge);
            if (bornYear < 1950)
            {
                Console.WriteLine("You are old !!!");
            }
            else
            {
                Console.WriteLine("You are young !!!");
            }
        }
        else
        {
            Console.WriteLine("Sorry, but the age you have entered is invalid.");
            Console.WriteLine();
            
        }
    }
}

