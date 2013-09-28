//  Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceWords
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../text.txt");
        Console.WriteLine("The old text is : {0}",input.ReadToEnd());
        input = new StreamReader("../../text.txt");
        StreamWriter newText = new StreamWriter("newText.txt");
        using (input)
        {
            string unReplaced = input.ReadToEnd();
            unReplaced = unReplaced.Replace("start", "finish");
            using (newText)
            {
                Console.WriteLine("The new text is : \n{0}",unReplaced);
                newText.Write(unReplaced);
            }
        }
    }
}

