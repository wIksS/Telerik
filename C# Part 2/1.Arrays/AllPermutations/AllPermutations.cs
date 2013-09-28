//  * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
//	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

//  * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
//	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;
using System.Collections.Generic;

public class SubsetsPermutations
{
    static int N = int.Parse(Console.ReadLine());
    static int[] numbers = new int[N];
    static int count = 0;

    static void Main()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        Queue<HashSet<int>> subsetsQueue = new Queue<HashSet<int>>();
        HashSet<int> emptySet = new HashSet<int>();
        subsetsQueue.Enqueue(emptySet);
        while (subsetsQueue.Count > 0)
        {
            HashSet<int> subset = subsetsQueue.Dequeue();
                        
            if (subset.Count == N)
            {
                Console.Write("{ ");
                foreach (int word in subset)
                {
                    Console.Write("{0} ", word);
                }
                Console.WriteLine("}");
            }

            foreach (int element in numbers)
            {
                if (!subset.Contains(element))
                {
                    HashSet<int> newSubset = new HashSet<int>();
                    newSubset.UnionWith(subset);
                    newSubset.Add(element);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
        }
    }
}