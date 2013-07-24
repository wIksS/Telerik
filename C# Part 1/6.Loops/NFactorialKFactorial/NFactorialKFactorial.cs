//  Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NFactorialKFactorial
{
    static void Main()
    {
        Console.Write("Enter N : ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter K : ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nFactDividedBykFact=1;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int j = 1; j <= k; j++)
        {
            kFact *= j;
        }
        Console.WriteLine("N! = {0}\nK! = {1}",nFact,kFact);
        if ((1<kFact)&&(kFact<nFact))
        {
            nFactDividedBykFact = nFact / kFact;
            Console.WriteLine("!N/!K = {0}", nFactDividedBykFact);
        }
        else
        {
            Console.WriteLine("Incorrect data");
        }
        
    }
}

