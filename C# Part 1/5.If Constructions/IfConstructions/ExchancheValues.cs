using System;

class ExchancheValues
{
    static void Main()
    {
        int firstVariablie = int.Parse(Console.ReadLine());
        int secondVariable = int.Parse(Console.ReadLine());
        int biggerVariable = firstVariablie;
        if (firstVariablie>secondVariable)
        {
            Console.WriteLine("The first one is greater than the second one !");
            firstVariablie = secondVariable;
            secondVariable = biggerVariable;
            Console.WriteLine(firstVariablie);
            Console.WriteLine(secondVariable);
            //Console.WriteLine("The bigger number is : {0}",biggerVariable);
        }
        else
        {
            Console.WriteLine("The first number is smaller than the second");
        }

    }
}

