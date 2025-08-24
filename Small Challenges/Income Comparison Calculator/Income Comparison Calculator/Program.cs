using System;

class Program
{
    static void Main()
    {
        // Program title
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1 input 
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine());  // user enters hourly rate
        Console.WriteLine("Hours worked per week?");
        double hoursPerWeek1 = Convert.ToDouble(Console.ReadLine()); // user enters hours per week

        // Calculate annual salary (hourly pay * weekly hours * 52 weeks)
        double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;


        // Person 2 input 
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine());  // user enters hourly rate
        Console.WriteLine("Hours worked per week?");
        double hoursPerWeek2 = Convert.ToDouble(Console.ReadLine()); // user enters hours per week

        // Calculate Person 2’s annual salary
        double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;


        // Results
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        // Check which salary is higher and display True/False
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(annualSalary1 > annualSalary2);

        Console.ReadLine(); // Keep the console window open
    }

}
