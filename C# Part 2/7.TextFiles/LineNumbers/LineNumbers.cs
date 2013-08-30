//  Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        StreamReader file = new StreamReader("../../App.Config");
        StreamWriter numberedFile = new StreamWriter("numberedFile.txt");
        using (file)  
        {
            int curLine = 1;
            StringBuilder line = new StringBuilder();
            string newLine = file.ReadLine();
            using (numberedFile)
            {
                while (newLine != null)
                {
                    line.Insert(0, curLine.ToString() + " ");
                    line.Append(newLine);
                    numberedFile.WriteLine(line);
                    line.Clear();
                    curLine++;
                    newLine = file.ReadLine();
                }
            }
        }

        StreamReader newFile = new StreamReader("numberedFile.txt");
        using (newFile)
        {
            Console.WriteLine("The new file is : ");
            Console.Write(newFile.ReadToEnd());
        }
    }
}

