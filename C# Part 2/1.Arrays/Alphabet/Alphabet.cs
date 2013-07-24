//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;

class Alphabet
{
    static void Main()
    {
        char[] alphabet = new char[] { 'n','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
            'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };       // vsi4ki bukvi sa glavni zashtoto v uslovieto pishe A - Z s golqma
        Console.Write("Enter the word : ");
        string word = Console.ReadLine();
        char[] array = word.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (array[i]==alphabet[j])
                {
                    Console.Write("The index of the {1} letter is : {0}",j,i+1);
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}

