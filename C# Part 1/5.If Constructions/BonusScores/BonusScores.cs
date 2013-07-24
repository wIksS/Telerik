using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter a digit");
        int score = int.Parse(Console.ReadLine());
        switch (score)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine(score=score*10);
                break;
            case 4:
            case 5:
            case 6: Console.WriteLine(score=score*100);
                break;
            case 7:
            case 8:
            case 9: Console.WriteLine(score=score*1000);
                break;
            default: Console.WriteLine("The number you have entered is not a digit");
                break;
        }
    }
}

