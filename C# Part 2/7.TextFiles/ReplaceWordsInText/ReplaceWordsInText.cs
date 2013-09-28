//  Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWords
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../text.txt");
        Console.WriteLine("The old text is : {0}", input.ReadToEnd());
        input = new StreamReader("../../text.txt");
        StreamWriter newText = new StreamWriter("newText.txt");
        using (input)
        {
            string unReplaced = input.ReadToEnd();
            unReplaced = Regex.Replace(unReplaced,"start","finish");
            // you can change that with whatever word you want
            using (newText)
            {
                Console.WriteLine("The new text is : \n{0}", unReplaced);
                newText.Write(unReplaced);
            }
        }
    }
}

