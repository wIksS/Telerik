using System;

class GreaterOf2Numbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        bool greaterNum = firstNum > secondNum;
        Console.WriteLine("The greater num is the first one ! {0}",greaterNum);
    }
}

