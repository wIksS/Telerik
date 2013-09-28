//Write a program that compares two char arrays lexicographically (letter by letter).
using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter the first char array : ");
        string firstText = Console.ReadLine();
        Console.Write("Enter the second char array : ");
        string secondText = Console.ReadLine();
        char[] firstArray = firstText.ToCharArray();  //prehvyrlqm stringyt kym masiv ot charove
        char[] secondArray = secondText.ToCharArray();   //syshtoto kato gornoto
        bool areEqual = true;  // shte go izpolzvam za da znam dali sa ravni elementite
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i]!=secondArray[i])
            {
                areEqual = false;  // ako sa razli4ni zna4i masivite ne sa ednakvi
            }
        }
        Console.WriteLine("All elements are equal ---> {0}", areEqual);
    }
}

