//  Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class Program
{
    static void Main()
    {
        int n = 10000000;
        long[] array = new long[n]; // pravq masiv s vsi4kite 4isla ot 1 do 10 miliona
        for (int i = 0; i < n-1; i++)
        {
            array[i] = i+2;
        }
        int p = 2;
        while (p<n)
        {
            for (int i = p+1; i < n+2; i++)
            {
                if (i % p == 0)
                {
                    array[i - 2] = 0;
                }
            }
            if (p==2)
            {
                p++;
            }
            else
            {
                p += 2;
            }
        }
        for (int i = 0,counter = 1; i < n; i++)
        {
            if (array[i] != 0)
            {
                Console.WriteLine("The {0} prime number is : {1}",counter,array[i]);
                counter++;
            }
        }
        
    }
}

