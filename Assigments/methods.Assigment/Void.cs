using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// A void class is a normal class that can be instantiated
public class Void
{
    // A void method that takes an integer, divides it by 2, and prints the result
    public void DivideByTwo(int number)
    {
        int result = number / 2; // Do the math
        Console.WriteLine($"{number} divided by 2 = {result}"); // Print the result
    }

    // A method that uses an output parameter to return the divided value
    public void DivideWithOutput(int number, out int result)
    {
        result = number / 2; // Assign the division result to the output parameter
    }

    // Overloaded method #1: takes an int and returns it multiplied by 10
    public int OverloadExample(int number)
    {
        return number * 10; // Return the result
    }

    // Overloaded method #2: takes a double and returns it divided by 100
    public double OverloadExample(double number)
    {
        return number / 100; 
    }
}