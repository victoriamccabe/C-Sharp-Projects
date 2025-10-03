using System;

namespace ZodiacApp
{
    class Program
    {
        // A const variable
        const string Greeting = "Welcome to the Zodiac Sign Finder!";

        static void Main(string[] args)
        {
            // Print greeting using const
            Console.WriteLine(Greeting);

            // Using 'var' for type inference (compiler knows this is a DateTime)
            var today = DateTime.Now;
            Console.WriteLine($"Today's date: {today.ToShortDateString()}");

            // Ask for user's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Ask for day of birth
            Console.Write("Enter your day of birth (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Ask for month of birth
            Console.Write("Enter your month of birth (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Create Person object using constructor chaining
            // (The constructor with 3 parameters will call the constructor with 1 parameter)
            Person person = new Person(name, day, month);

            // Display results
            Console.WriteLine($"\nHello {person.Name}!");
            Console.WriteLine($"Your Zodiac Sign is: {person.ZodiacSign}");

            // Pause program so window does not close immediately
            Console.ReadLine();
        }
    }
}