using System;

class PrimeNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double maxDivider = Math.Sqrt(number);
        bool isPrime = true;
        int divider;
        for (divider = 2; divider < maxDivider; divider++)
        {
            if (number % divider == 0)
            {
                isPrime = false;
            }
        }
        if (number == 4)
        {
            isPrime = false;
        }
        Console.WriteLine(isPrime);
    }
}

