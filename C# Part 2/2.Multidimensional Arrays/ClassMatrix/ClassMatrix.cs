
using System;

class ClassMatrix
{
    static void Main(string[] args)
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 1;
        matrix1[1, 1] = -12;

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 1] = 2;
        matrix2[1, 1] = 24;

        // izpolzval sym primerite ot sybotniq workshop

        Console.WriteLine("Adding matrixes : ");
        Matrix sum = matrix1 + matrix2;
        Console.WriteLine(sum.ToString());
        Console.WriteLine();

        Console.WriteLine("Substracting matrixes : ");
        Matrix substracting = matrix1 - matrix2;
        Console.WriteLine(substracting.ToString());
        Console.WriteLine();

        Console.WriteLine("Multiplying matrixes : ");
        Matrix multiplying = matrix1 * matrix2;
        Console.WriteLine(multiplying.ToString());
    }
}

