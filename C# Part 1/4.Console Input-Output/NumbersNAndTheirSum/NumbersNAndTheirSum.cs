using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersNAndTheirSum
{
    static void Main()
    {
        Console.WriteLine("Insert numbers untill you press esc !");
        int sum = 0;
        int n = int.Parse(Console.ReadLine());
        sum = sum + n;

        for (int i = 0, j = 1; i < j; i++, j++)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                
                Console.WriteLine("The sum of the numbers is : {0}",sum); 
                break;
            }
            else
            {
                n = int.Parse(Console.ReadLine());
                sum = sum + n;
            }
        }               
    }
}

