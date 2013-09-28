//  Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;

class CompareFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader("../../App.Config");
        StreamReader secondFile = new StreamReader("../../App.Config");
        //StreamReader secondFile = new StreamReader("../../Program.cs");
        // you can change this whenever you want
        int equalLines = 0;
        string firstLine = firstFile.ReadLine();
        string secondLine = secondFile.ReadLine();

        while (firstLine != null)
        {
            if (firstLine.Length != secondLine.Length)
            {
                firstFile.ReadLine();
                secondFile.ReadLine();
                continue;
            }
            //if the lenght is diffrent the lines would be different too thats why i do continue
            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] != secondLine[i])
                {
                    firstFile.ReadLine();
                    secondFile.ReadLine();
                    continue;
                }
            }
            equalLines++;
            firstLine = firstFile.ReadLine();
            secondLine = secondFile.ReadLine();
        }
        Console.Write("The equal lines are : ");
        Console.WriteLine(equalLines);
    }
}

