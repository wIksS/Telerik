using System;

class SetValueAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer n :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value v : (0 or 1)");
        int v = int.Parse(Console.ReadLine());
        do
        {
            if ((v != 0) && (v != 1))
	        {
                Console.WriteLine("The value you have entered is invalid.\nPlease try again !");
		        v = int.Parse(Console.ReadLine());
	        }
        } while ((v != 0) && (v != 1));
        Console.WriteLine("Enter the position of the bit p: ");
        int p = int.Parse(Console.ReadLine());
        if (v==0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The new number is :");
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("The new number is :");
            Console.WriteLine(result);
        }
    }
}

