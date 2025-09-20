using System;

class Program
{
    static void Main()
    {
        // Display the program's welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check weight with ternary operator and exit if too heavy
        string weightMessage = (weight > 50) ? "Package too heavy to be shipped via Package Express. Have a good day." : "";

        // Loop
        if (weightMessage != "")
        {
            Console.WriteLine(weightMessage);
            return;
        }

        // Prompt the user for dimensions
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check dimensions with ternary operator
        string sizeMessage = ((width + height + length) > 50)
            ? "Package too big to be shipped via Package Express." : "";

        // Loop
        if (sizeMessage != "")
        {
            Console.WriteLine(sizeMessage);
            return;
        }

        // Calculate the quote: (width × height × length × weight) / 100
        decimal quote = (width * height * length * weight) / 100;

        // Use ternary to decide what to display (in this case, always valid)
        string result = (quote > 0)
            ? $"Your estimated total for shipping this package is: ${quote:F2}"
            : "Unable to calculate a shipping quote.";

        // Display the result
        Console.WriteLine(result);

        // End with a thank you message
        Console.WriteLine("Thank you!");
    }
}