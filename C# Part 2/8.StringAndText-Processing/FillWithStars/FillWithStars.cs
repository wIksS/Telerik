//  Write a program that reads from the console a string of maximum 20 characters.
//  If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
using System;
using System.Text;

class FillWithStars
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a string with less than 20 chars : ");
            string text = Console.ReadLine();
            if (text.Length > 20)
            {
                throw new ArgumentException();
            }

            int stars = 20 - text.Length;
            StringBuilder newText = new StringBuilder(text);
            newText.Append(new string('*', stars));
            Console.WriteLine(newText.ToString());
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The string must have less than 20 chars !!!!");
        }
    }
}

