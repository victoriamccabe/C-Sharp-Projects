using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Example of a for loop iterating through an array of integers
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine($"Passing test score: {testScores[i]}");
        //    }
        //}
        //Console.ReadLine();

        //// Another example of a for loop iterating through an array of strings
        //string[] names = { "Jesse", "Erik", "Daniel", "Adam", "Eve", "Seth" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //        Console.WriteLine(names[j]);
        //}


        //    Console.ReadLine();


        
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach(int score in testScores) // "testScores" is the List, "score" is the item in the List
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine($"Passing test score {score}");
        //    }
        //}
        //Console.ReadLine();

        //// Foreach example
        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    if (name == "Adam")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();


        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();
            foreach (int score in testScores) {
                if (score > 85)
            {
                passingScores.Add(score);
            }

        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
        
            
}
    

