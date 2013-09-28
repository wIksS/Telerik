//  Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 

using System;

class AddTwoPolinoms
{
    static void Main()
    {
        Console.Write("Enter the exponent of the first polinom : ");
        // exponent means (stepenta na polinomyt) the degree of the polinom
        int firstPolinomExponent = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent of the second polinom : ");
        int secondPolinomExponent = int.Parse(Console.ReadLine());
        
        Console.WriteLine(PrintResult(AddPolinoms(firstPolinomExponent,secondPolinomExponent)));
    }

    static string PrintResult(int[] addedPolinom)
    {
        string result="";
        for (int i = addedPolinom.Length-1; i >= 0; i--)
        {
            if (i > 1)
            {
                result += addedPolinom[i].ToString() + "x^" + i + " " + "+" + " ";
            }
            else if (i==1)
            {
                result += addedPolinom[i].ToString()+"x" + " " + "+" + " ";
            }
            else
            {
                result += addedPolinom[i].ToString();
            }
        }
        return result;
    }
    static int[] AddPolinoms(int firstPolinomExponent, int secondPolinomExponent)
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
                addedPolinom[i] = firstPolinom[i] + secondPolinom[i];
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
                addedPolinom[i] = firstPolinom[i] + secondPolinom[i];
            }
            for (int j = i; j < secondPolinom.Length; j++)
            {
                addedPolinom[j] = secondPolinom[j];
            }
        }
        return addedPolinom;
    }
}

