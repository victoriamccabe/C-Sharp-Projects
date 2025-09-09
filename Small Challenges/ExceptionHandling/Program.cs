using System;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine($"{numberOne} divided by {numberTwo} equals {numberThree}");
            Console.ReadLine();
        }
        // Only catches format exceptions
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }

        // Only catches divide by zero exceptions
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
            Console.ReadLine();
        }
        // Catches any other exceptions
        catch (Exception ex) 
        { Console.WriteLine(ex.Message); }

        // Always runs this code no matter what happens in the try block 
        finally
        {
            Console.ReadLine();
        }
        
    }
}
