using System;

class AssignObjectWithString
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object twoStrings = hello + " " + world;
        string objString= (string)twoStrings;
        Console.WriteLine(objString);
    }
}

