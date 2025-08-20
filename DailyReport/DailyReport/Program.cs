using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report."); // Display the header
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); // Get the student's name
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine(); // Get the course name
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine()); // Get the page number
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); // Get help status
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine(); // Get positive experiences
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine(); // Get additional feedback
            Console.WriteLine("How many hours did you study today?");
            byte hoursStudied = Convert.ToByte(Console.ReadLine()); // Get hours studied
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.Read(); // Wait for user input before closing the console window
        }
    }
}