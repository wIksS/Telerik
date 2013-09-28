//  Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;

class NFactorial
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        string firstNum;
        string secondNum="1";
        string result;
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            firstNum = i.ToString();
            secondNum = GetResult(firstNum,secondNum);             
        }
        result = secondNum;
        Console.Write("n! of {0} is : ",n);
        Console.WriteLine(result);
    }
    static string GetResult(string firstNum, string secondNum)
    {
        int diference;
        if (secondNum.Length>firstNum.Length)
	    {
            diference = secondNum.Length - firstNum.Length - 1;		 
	    }
        else
        {
            diference = 0;
        }
        int[,]matrix = MultiplyNums(firstNum, secondNum);
        int counter1 = firstNum.Length;
        int counter2 = 1;
        int minus = secondNum.Length - firstNum.Length;
        int[] array = new int[firstNum.Length + secondNum.Length + 1];
        for (int row = secondNum.Length-1; row >= 0; row--,counter1--,counter2++)
        {
            int counter = array.Length-counter2;
            for (int col = firstNum.Length + counter1; col >= counter1; col--,counter--)
            {
                if (counter1 >= 0)
                {
                    if (array[counter] + matrix[row, col - counter1] < 10)
                    {
                        array[counter] += matrix[row, col - counter1];
                    }
                    else
                    {
                        array[counter] += (matrix[row, col - counter1]);
                        array[counter] %= 10;
                        array[counter-1]++;
                    }
                    if (counter1<0)
                    {
                        counter1=0;
                    }
                }
                else
                {
                    if (array[counter] + matrix[row, col - counter1] < 10)
                    {
                        array[counter] += matrix[row, col - counter1];
                    }
                    else
                    {
                        array[counter] += matrix[row, col - counter1] % 10;
                        array[counter] %= 10;
                        array[counter-1]++;
                    }
                }
            }
        }
        string result = string.Join("", array);
        while (result[0]=='0')
        {
            result = result.Remove(0, 1);
        }
        return result;
    }
    

    static int[,] MultiplyNums(string firstNum, string secondNum)
    {
        int counter = 0;
        int[] firstArray = new int[firstNum.Length];
        int[] secondArray = new int[secondNum.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = firstNum[i] - 48;
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = secondNum[i] - 48;
        }
        int[,] matrix = new int[secondNum.Length, firstArray.Length+1];
        for (int row = secondNum.Length - 1; row >= 0; row--)
        {
            for (int col = firstArray.Length; col > 0; col--)
            {
                if (secondArray[row] * firstArray[col-1] < 10)
                {
                    matrix[row, col] += secondArray[row] * firstArray[col-1];
                }                
                if (secondArray[row] * firstArray[col-1]>9)
                {
                    matrix[row,col]+= (secondArray[row] * firstArray[col-1])%10;
                    matrix[row, col-1] += (secondArray[row] * firstArray[col-1]) / 10;
                }
            }   
        }
        return matrix;
    }
    // im going to use my solving to task 8 in this task 

    static string AddDigits(string firstNum, string secondNum)
    {
        int[] firstArray = new int[firstNum.Length];
        int[] secondArray = new int[secondNum.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = firstNum[i] - 48;
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = secondNum[i] - 48;
        }
        int max = firstArray.Length;
        if (max < secondArray.Length)
        {
            max = secondArray.Length;
        }
        int[] addedDigits = new int[max + 1];
        int counter1 = 1;
        int counter2 = 1;
        int minus1 = addedDigits.Length - 1;
        int minus2 = addedDigits.Length - 1;
        for (int i = addedDigits.Length - 1; i > 0; i--)
        {
            while (minus1 > firstArray.Length)
            {
                counter1++;
                minus1--;
            }
            while (minus2 > secondArray.Length)
            {
                counter2++;
                minus2--;
            }
            if (i - counter1 < 0)
            {
                addedDigits[i] += secondArray[i - counter2];
                if (addedDigits[i] > 9)
                {
                    addedDigits[i] -= 10;
                    addedDigits[i - 1] += 1;
                }
                continue;
            }
            if (i - counter2 < 0)
            {
                addedDigits[i] += firstArray[i - counter1];
                if (addedDigits[i] > 9)
                {
                    addedDigits[i] -= 10;
                    addedDigits[i - 1] += 1;
                }
                continue;
            }
            if (firstArray[i - counter1] + secondArray[i - counter2] > 9)
            {
                addedDigits[i] += (firstArray[i - counter1] + secondArray[i - counter2]) % 10;
                addedDigits[i - 1] += 1;
            }
            else
            {
                addedDigits[i] += firstArray[i - counter1] + secondArray[i - counter2];
            }
        }
        string result = string.Join("", addedDigits);
        if (result[0] == '0')
        {
            result = result.Remove(0, 1);
        }
        return result;
    }
}

