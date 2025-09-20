
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek currentDay; // Variable to store the valid day entered by the user
            bool isValidInput = false; // Set a flag to track if the input is valid

        // Loop until the user enters a valid day ♥
        while (!isValidInput)
            {
                // Prompt the user for input
                Console.WriteLine("Please enter the current day of the week:");
                string userInput = Console.ReadLine(); // Read user input

                try
                {
                    // Try to parse the user input into the DaysOfWeek enum
                    currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput, true);

                    // If succeed set the flag to true to exit the loop
                    isValidInput = true;

                    // Print the successfully parsed day
                    Console.WriteLine($"You entered: {currentDay}");
                }

            // Catch any exception that occurs during parsing and ask for input again
            catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }


        Console.ReadLine();
    }
}
