//  Extend the program to support also subtraction and multiplication of polynomials.

using System;

class MultiplicationOfPolinoms
{
    static void Main()
    {
        Console.Write("Enter the exponent of the first polinom : ");
        // exponent means (stepenta na polinomyt) the degree of the polinom
        int firstPolinomExponent = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent of the second polinom : ");
        int secondPolinomExponent = int.Parse(Console.ReadLine());
        Console.WriteLine("What do you want :\n1 : Multiply 2 polinoms");
        Console.WriteLine("2 : Substract 2 polinoms");
        Console.Write("Press \"1\" or \"2\" : ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine(PrintResult(MultiPlyPolinoms(firstPolinomExponent, secondPolinomExponent)));

        }
        else if (choice == 2)
        {
            Console.WriteLine(PrintResult(SubstractPolinoms(firstPolinomExponent, secondPolinomExponent)));
        }
        else
        {
            Console.WriteLine("Whrong input !!!");
        }
    }

    static string PrintResult(int[] addedPolinom)
    {
        string result = "";
        for (int i = addedPolinom.Length - 1; i >= 0; i--)
        {
            if (addedPolinom[i] < 0)
            {
                return "whrong input";
            }
            else if (i > 1)
            {
                result += addedPolinom[i].ToString() + "x^" + i + " " + "+" + " ";
            }
            else if (i == 1)
            {
                result += addedPolinom[i].ToString() + "x" + " " + "+" + " ";
            }
            else
            {
                result += addedPolinom[i].ToString();
            }
        }
        return result;
    }
    static int[] MultiPlyPolinoms(int firstPolinomExponent, int secondPolinomExponent)
    {
        int[] firstPolinom = new int[firstPolinomExponent];
        int[] secondPolinom = new int[secondPolinomExponent];
        Console.WriteLine("FIRST ARRAY : ");
        for (int i = 0; i < firstPolinom.Length; i++)
        {
            Console.Write("{0} coefficient = ", i);
            firstPolinom[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("SECOND ARRAY : ");
        for (int i = 0; i < secondPolinom.Length; i++)
        {
            Console.Write("{0} coefficient = ", i);
            secondPolinom[i] = int.Parse(Console.ReadLine());
        }
        int[] addedPolinom;
        if (firstPolinom.Length > secondPolinom.Length)
        {
            int i;
            addedPolinom = new int[firstPolinom.Length];
            for (i = 0; i < secondPolinom.Length; i++)
            {
                addedPolinom[i] = firstPolinom[i] * secondPolinom[i];
            }
            for (int j = i; j < firstPolinom.Length; j++)
            {
                addedPolinom[j] = firstPolinom[j];
            }
        }
        else
        {
            int i;
            addedPolinom = new int[secondPolinom.Length];
            for (i = 0; i < firstPolinom.Length; i++)
            {
                addedPolinom[i] = firstPolinom[i] * secondPolinom[i];
            }
            for (int j = i; j < secondPolinom.Length; j++)
            {
                addedPolinom[j] = secondPolinom[j];
            }
        }
        Console.Write("Multiplyed polinoms : ");
        return addedPolinom;
    }
    static int[] SubstractPolinoms(int firstPolinomExponent, int secondPolinomExponent)
    {
        int[] firstPolinom = new int[firstPolinomExponent];
        int[] secondPolinom = new int[secondPolinomExponent];
        Console.WriteLine("FIRST ARRAY : ");
        for (int i = 0; i < firstPolinom.Length; i++)
        {
            Console.Write("{0} coefficient = ", i);
            firstPolinom[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("SECOND ARRAY : ");
        for (int i = 0; i < secondPolinom.Length; i++)
        {
            Console.Write("{0} coefficient = ", i);
            secondPolinom[i] = int.Parse(Console.ReadLine());
        }
        int[] addedPolinom;
        if (firstPolinom.Length > secondPolinom.Length)
        {
            int i;
            addedPolinom = new int[firstPolinom.Length];
            for (i = 0; i < secondPolinom.Length; i++)
            {
                addedPolinom[i] = firstPolinom[i] - secondPolinom[i];
            }
            for (int j = i; j < firstPolinom.Length; j++)
            {
                addedPolinom[j] = firstPolinom[j];
            }
        }
        else
        {
            int i;
            addedPolinom = new int[secondPolinom.Length];
            for (i = 0; i < firstPolinom.Length; i++)
            {
                addedPolinom[i] = firstPolinom[i] - secondPolinom[i];
            }
            for (int j = i; j < secondPolinom.Length; j++)
            {
                addedPolinom[j] = secondPolinom[j];
            }
        }
        Console.Write("Substracted polinoms : ");
        return addedPolinom;
    }
}

