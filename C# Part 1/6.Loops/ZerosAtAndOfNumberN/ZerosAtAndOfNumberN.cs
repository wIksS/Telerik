using System;
using System.Numerics;

class ZerosAtAndOfNumberN
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger sum = 0;
        BigInteger lastDigit=1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine(nFactorial);

        if (lastDigit==0)
        {
            sum++;
        }

        do
        {
            lastDigit = nFactorial % 10;
            nFactorial = nFactorial / 10;

            if (lastDigit == 0)
            {
                sum = sum + 1 ;
            }

            else
            {
                break;
            }

        } while (nFactorial>10);

        Console.WriteLine(sum);
    }
}

