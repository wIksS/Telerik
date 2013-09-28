//  Write a program that can solve these tasks:
//  Reverses the digits of a number
//  Calculates the average of a sequence of integers
//  Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//		Provide a simple text-based menu for the user to choose which task to solve.
//		Validate the input data:
//  The decimal number should be non-negative
//  The sequence should not be empty
//  a should not be equal to 0

using System;
using System.Text;
using System.Threading;

class SolveTaks
{
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        decimal reversedDigit;
        int sequence;
        string choice = "";
        decimal a;
        decimal b;
        decimal x;
        Console.WriteLine("Enter what task you want to solve : ");
        Console.WriteLine("1 : Reverse the digits of a number");
        Console.WriteLine("2 : Calculate the average of a sequence of integers");
        Console.WriteLine("3 : Solve a linear equation a * x + b = 0");
        Console.Write("Enter \"1\", \"2\" or \"3\" for your choice : ");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.Write("Enter the num : ");
            reversedDigit = decimal.Parse(Console.ReadLine());
            if (reversedDigit < 0)
            {
                Console.WriteLine("Whrong input!");
                return;
            }
            Console.Write("The reversed num is : ");
            Console.WriteLine(ReverseDigits(reversedDigit));
        }
        if (choice == "2")
        {
            Console.Write("Enter the lenght of the sequence : ");
            sequence = int.Parse(Console.ReadLine());
            if (sequence<=0)
            {
                Console.WriteLine("Whrong input");
                return;
            }
            Console.WriteLine(AverageOfIntegers(sequence));
        }
        if (choice == "3")
        {
            Console.Write("Enter a : ");
            a = decimal.Parse(Console.ReadLine());
            if (a==0)
            {
                Console.WriteLine("Whrong input!");
                return;
            }
            Console.Write("Enter x : ");
            x = decimal.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The result is : " + LinearEquation(a,b,x));
        }
    }

    static decimal AverageOfIntegers(int sequence)
    {
        int[] array = new int[sequence];
        int sum = 0;
        for (int i = 0; i < sequence; i++)
        {
            Console.Write("Enter the {0} number : ",i + 1);
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }
        decimal average = sum / (decimal)sequence;
        Console.Write("The average is : ");
        return average;

    }

    static decimal LinearEquation(decimal a, decimal b, decimal x)
    {
        decimal result = (a * x) + b;
        return result;
    }
    static StringBuilder ReverseDigits(decimal number)
    {
        StringBuilder num = new StringBuilder(number.ToString());
        int decPoint = 0;
        bool isDec = false;
        for (decPoint = 0; decPoint < num.Length; decPoint++)
        {
            if (num[decPoint]=='.')
            {
                num.Remove(decPoint, 1);
                isDec = true;
                break;
            }
        }
        for (int i = 0; i < num.Length/2; i++)
        {
            char temp = num[i];
            num[i] = num[num.Length - i -1];
            num[num.Length - i - 1] = temp;
        }
        if (isDec)
        {
            bool isUsed = true;
            char temporary = num[decPoint];
            char last = num[num.Length - 1];
            for (int i = decPoint+1; i < num.Length; i++)
            {
                num[decPoint] = '.';
                if (i < num.Length - 1)
                {
                    num[i]=temporary;
                    temporary=num[i+1];
                    isUsed = false;
                }
                else
                {
                    if (isUsed)
                    {
                        num[i] = temporary;
                    }
                    num.Append(last);
                    break;
                }

            }
        }
        return num;
    }
}

