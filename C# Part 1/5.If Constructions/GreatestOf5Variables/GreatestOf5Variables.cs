using System;

class GreatestOf5Variables
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if ((a > b) && (a > c) && (a > x) && (a > y))
        {
            Console.WriteLine("The biggest number is : {0} , the first one.",a);
        }                                                  
        if ((b > a) && (b > c) && (b > x) && (b > y))      
        {                                                  
            Console.WriteLine("The biggest number is : {0} ,the second one",b);
        }                                                  
        if ((c > a) && (c > b) && (c > x) && (c > y))      
        {                                                  
            Console.WriteLine("The biggest number is : {0} ,the third one", c);
        }                                                  
        if ((x > a) && (x > b) && (x > c) && (x > y))      
        {                                                  
            Console.WriteLine("The biggest number is : {0} ,the fourth one", x);
        }                                                  
        if ((y > a) && (y > b) && (y > c) && (y > x))      
        {                                                  
            Console.WriteLine("The biggest number is : {0} ,the fifth one", y);
        }

       
    }
}

