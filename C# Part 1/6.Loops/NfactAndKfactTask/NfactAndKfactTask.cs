//  Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;
using System.Numerics;

class NfactAndKfactTask
{
    static void Main()
    {
        Console.Write("Enter N : ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter K : ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger kMinusNfact = 1;
        BigInteger nFactMultipliedBykFact = 1;
        BigInteger result;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;             //  Calculates N factorial
        }
        for (int j = 1; j <= k; j++)
        {
            kFact *= j;             //  Calculates K factorial
        }
        for (int g = 1; g <= k-n; g++)
        {
            kMinusNfact *= g;
        }
        Console.WriteLine("N! = {0}\nK! = {1}", nFact, kFact);
        if ((1 < nFact) && (nFact < kFact))
        {
            nFactMultipliedBykFact = nFact * kFact;
            result = nFactMultipliedBykFact / kMinusNfact;
            Console.WriteLine("N! * K! = {1}\n(K - N)! = {2}\nN! * K! / (K-N)! = {0} ", result, nFactMultipliedBykFact, kMinusNfact);
        }
        else
        {
            Console.WriteLine("Incorrect data");
        }
    }
}

