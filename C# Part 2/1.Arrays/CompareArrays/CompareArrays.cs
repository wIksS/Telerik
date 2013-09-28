//  Write a program that reads two arrays from the console and compares them element by element.
using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Insert the lenght of the two array : ");
        int arrayLenght = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the values of the first array :");
        int[] firstArray = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine()); //4eta stoinostite na masivyt
        }
        Console.WriteLine("Now enter the values of the second array :");
        int[] secondArray = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine()); //4eta vtoriqt masiv
        }
        bool isEqual = true;   // booleva promenliva  koqto shte stane false ako ne sa ravni
        for (int i = 0; i < arrayLenght; i++)
        {
            if (firstArray[i]!=secondArray[i])
            {
                isEqual = false;   //ako nqkoi ot elementite ne syvpada stava false
            }
        }
        Console.WriteLine("All elements are equal ---> {0}",isEqual);
    }
}

