using System;

class First10Numbers
{
    static void Main()
    {
        Console.WriteLine("Insert the first number of the sequence :");
        int firstNumber = int.Parse(Console.ReadLine()); 
        for (int i =firstNumber; i <=firstNumber+10; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0},",i);
            }
            else
            {
                Console.Write("{0},",-i);
            }
        }
    }
}

