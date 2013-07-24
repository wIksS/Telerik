using System;

class IsFemaleVariable
{
    static void Main()
    {
        Console.WriteLine("Are you female?");
        string x = Console.ReadLine();
        if ((x == "male") || (x == "Male"))
        {
            bool isFemale = false;
            Console.WriteLine(isFemale);
        }
        if ((x == "female") || (x == "Female"))
        {
            bool isFemale = true;
            Console.WriteLine(isFemale);
        }
    }
}

