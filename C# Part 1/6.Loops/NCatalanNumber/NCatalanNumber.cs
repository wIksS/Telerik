using System;

class NCatalanNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long firstExpression = ((1 / n) + 1) * (2 * n / n);
        long n2Factorial = 1;
        long nFactorial = 1;
        long nPlusOneFact = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            n2Factorial *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            nPlusOneFact *= i;
        }
        firstExpression = n2Factorial / (nFactorial * nPlusOneFact);
        Console.WriteLine(firstExpression);
    }
}

