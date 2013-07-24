//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

using System;

class ElementsMultiplyedBy5
{
    static void Main()
    {
        int[] array = new int[20];  //deklariram masiv s 20 elementa
        Console.WriteLine("Insert the values of the array : ");
        for (int i = 0; i < array.Length; i++)  //obhojdam masivyt
        {
            array[i] = int.Parse(Console.ReadLine()); //4eta stoinostta na elementa
            array[i] *= 5;  //umnojavam dadeniqt element na 5
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} , ",array[i]);   //izpe4atvam noviqt masiv
        }
        Console.WriteLine();
    }
}

