using System;

class CatalanFormula
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int col = 1;

        for (int row = 0; row < n; row++, col++)
        {
            int counter = col;
            for (int i = 0; i < n; col++, i++)
            {
                Console.Write(col);
            }
            Console.WriteLine();
            col = counter;
        }

    }
}

