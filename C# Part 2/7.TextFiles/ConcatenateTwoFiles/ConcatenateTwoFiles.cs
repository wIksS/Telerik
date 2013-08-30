//  Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main()
    {
        Console.WriteLine("Enter the first file : ");
        StreamWriter firstFile = new StreamWriter("firstFile.txt");
        using (firstFile)
        {
            string first = Console.ReadLine();
            firstFile.Write(first);
        }

        Console.WriteLine("Enter the second file : ");
        StreamWriter secondFile = new StreamWriter("secondfile.txt");

        using (secondFile)
        {
            string second = Console.ReadLine();
            secondFile.Write(second);
        }

        StreamWriter newTextFile = new StreamWriter("newTextFile.txt");

        using (newTextFile)
        {
            StreamReader first = new StreamReader("firstFile.txt");
            using (first)
            {
                StreamReader second = new StreamReader("secondfile.txt");

                using (second)
                {
                    newTextFile.WriteLine(first.ReadToEnd());
                    newTextFile.WriteLine(second.ReadToEnd());
                }
            }
        }

        StreamReader newFile = new StreamReader("newTextFile.txt");
        using (newFile)
        {
            Console.WriteLine("The new file is : ");                   
            Console.Write(newFile.ReadToEnd());
        }
      
    }
}

