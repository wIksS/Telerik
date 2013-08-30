//  Write a program to check if in a given expression the brackets are put correctly.
//  Example of correct expression: ((a+b)/5-d).
//  Example of incorrect expression: )(a+b)).

using System;

class BracketsMistake
{
    static void Main()
    {
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        int brackets = 0;
        int start = -1;
        while (text.IndexOf('(',start+1)!= -1)
        {
            start = text.IndexOf('(', start+1);
            brackets++;
        }

        start = -1;
        while (text.IndexOf(')', start + 1) != -1)
        {
            start = text.IndexOf(')', start + 1);
            brackets--;
        }

        if (brackets == 0)
        {
            Console.WriteLine("The expression is correct");
        }
        else
        {
            Console.WriteLine("Incorrect expression");
        }
    }
}
