//  Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamReader input = new StreamReader("../../Program.cs");
        using (input) 
        {
            int curLine = 1;
            string line = input.ReadLine();
            while (line != null)
            {
                if (curLine % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                curLine++;
                line = input.ReadLine();
            }
        }
    }
}
