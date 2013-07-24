using System;

class DescendingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a>c)
            {
                if (c>b)
                {
                    Console.WriteLine("Descending numbers are : {0}  {1}  {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("Descending numbers are : {0}  {1}  {2}", a, b, c);
                }
            }
        }
        if (b > c) 
        {
            if (c > a) 
            {
                Console.WriteLine("Descending numbers are : {0}  {1}  {2}", b, c, a);
            }
            else
            {
                Console.WriteLine("Descending numbers are : {0}  {1}  {2}", b, a, c);
            }
        }
        if (c > b)
        {
            if (b > a)
            {
                Console.WriteLine("Descending numbers are : {0}  {1}  {2}", c, b, a);
            }
            else
            {
                Console.WriteLine("Descending numbers are : {0}  {1}  {2}", c, a, b);
            }
        }
    }
}

