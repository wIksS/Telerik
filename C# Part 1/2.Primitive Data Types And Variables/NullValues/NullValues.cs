using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        Console.WriteLine("The integer with value null is ->" + nullInt);
        nullInt = 5;
        Console.WriteLine("The integer with value 5 -> " + nullInt);
        double? nullDouble = null;
        Console.WriteLine("Double with value null is -> " + nullDouble);
        nullDouble = 5;
        Console.WriteLine("Double with value 5 is -> " + nullDouble);
        
    }
}

