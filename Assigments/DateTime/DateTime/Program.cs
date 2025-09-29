using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Prints the current date and time
        Console.WriteLine(DateTime.Now);

        // Asks the user for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Prints the number entered by the user as the exact time it will be in X hours, being X the number entered by the user
        Console.WriteLine($"In {number} hours, it will be: {DateTime.Now.AddHours(number)}");
    }
}