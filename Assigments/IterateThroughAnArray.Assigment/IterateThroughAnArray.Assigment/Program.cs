using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        // Introduce the app to the user
        Console.WriteLine(
            "Welcome to the Ultimate Name and List Tester!\n" +
            "This app has several fun features to help you explore names, ratings, and lists:\n" +
            "1. See how popular boys' names sound with your last name.\n" +
            "2. Rate each name on a scale of 1 to 10 and find your favorite.\n" +
            "3. Search for items in lists and see their positions.\n" +
            "4. Detect duplicates and see which items are unique or repeated.\n" +
            "5. Give feedback on whether you liked the app.\n" + 
            "\nLet's get started!\n"
            );
        Console.WriteLine("");
        Console.WriteLine("");
        //----------------Assigment Part 1-----------------------------
        // Assigment Step I
        // Declare and initialize a one-dimensional array of boys' names
        string[] boysNames = { "Declan", "Pablo", "Josiah", "Arthur", "Aspen" };
        Console.WriteLine("This is the Baby Name Tester!");
        Console.WriteLine("This app helps you imagine how certain first names sound with your last name.");
        Console.WriteLine("We’ll use a few popular boys names and combine them with your last name.");
        Thread.Sleep(1000); // Pause 1 sec

        // Assigment Step II
        // Ask the user for their first name
        Console.Write("\nFirst, what is your first name?: ");
        string firstName = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("Great! Now, what is your last name?: ");
        string lastName = Console.ReadLine();

        // Greet the user
        Console.WriteLine($"\nHello, {firstName} {lastName}!");
        Console.WriteLine("Let’s see how your last name sounds with these names...");
        Thread.Sleep(1000); // Pause 1 sec

        // Assigment Step III
        // First loop: Append user's last name to each boy's name 
        for (int i = 0; i < boysNames.Length; i++)
        {
            // Add the last name to the end of each boy's name
            boysNames[i] = boysNames[i] + " " + lastName;
        }

        // Assigment Step IV
        // Second loop: Print out each full name one at the time
        Console.WriteLine("\nHere are the full names:");
        for (int i = 0; i < boysNames.Length; i++)
        {
            Console.WriteLine(boysNames[i]);
            Thread.Sleep(500); // Puse for .5 sec
        }

        // End message
        Console.WriteLine("\nThat’s it! Hopefully this gave you some ideas.");
        Thread.Sleep(1000); // Pause 1 sec



        //----------------Assigment Part 3-----------------------------
        Console.WriteLine(""); // Just to add a space between parts

        Console.WriteLine("\nLet's rate these names on a scale of 1 to 10!");

        // Create an array to store the scores for each name
        int[] nameScores = new int[boysNames.Length];

        // Assigment Step I
        // First loop using "<" operator. Loop through each boy's name to get the user's rating
        for (int i = 0; i < boysNames.Length; i++)
        {
            int userRating = 0; // Variable to store the final valid rating
            bool validInput = false; // Flag to track if the input is valid

            while (!validInput) // Keep asking until input is valid
            {
                Console.Write($"How much do you like the name {boysNames[i]}? (1-10): ");

                int tempInput; // Temporary variable to hold user input
                if (int.TryParse(Console.ReadLine(), out tempInput))
                {
                    if (tempInput >= 1 && tempInput <= 10)
                    {
                        userRating = tempInput; // Assign valid input to userRating
                        validInput = true; // Input is valid, exit loop
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a number between 1 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number between 1 and 10.");
                }
            }

            nameScores[i] = userRating; // Store the valid rating in the array
        }

        // Assigment Step II
        // Second loop using "<=" operator. Loop through the names and their scores to display them
        // Calculate the total score of all names
        int totalScore = 0;
        for (int i = 0; i <= boysNames.Length - 1; i++)  // comparison: i <= boysNames.Length - 1
        {
            totalScore += nameScores[i];  // Add each name's score to the total
        }

        // Find the name with the highest score 
        // Initialize maxScore and bestName with the first element
        int maxScore = nameScores[0];
        string bestName = boysNames[0];

        // Loop through remaining names to find the highest score
        for (int i = 1; i < boysNames.Length; i++)
        {
            if (nameScores[i] > maxScore)  // If current score is higher than maxScore
            {
                maxScore = nameScores[i];  // Update maxScore
                bestName = boysNames[i];   // Update bestName
            }
        }

        // Display results to the user
        Console.WriteLine($"\nThe name you liked the most is {bestName} with a score of {maxScore}!");





        // ----------------Assignment Part 4-----------------------------
        // Assigment Step I
        // Create a list of unique string items 
        List<string> uniqueItems = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };

        // Assigment Step II
        // Ask the user to input text to search for in the list
        Console.WriteLine("\nLet's search for an item in our list!");
        Console.Write("Type a color to search for: ");
        string searchText = Console.ReadLine();
        bool matchFound = false; // Flag to check if a match is found

        // Assigment Step III
        // Loop through the list to find the matching item
        for (int i = 0; i < uniqueItems.Count; i++)
        {
            // Compare user input with the current list item
            if (uniqueItems[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Match found! '{uniqueItems[i]}' is at index {i}.");
                matchFound = true; // Set flag to true
                // Assigment Step V
                break; // Stop the loop after finding the first match
            }
        }

        // Assigment Step IV
        // Check if no match was found
        if (!matchFound)
        {
            Console.WriteLine($"Sorry, '{searchText}' is not on the list.");
        }



        // ----------------Assignment Part 5-----------------------------

        // Assigment Step I
        List<string> fruitList = new List<string> { "Apple", "Banana", "Orange", "Apple", "Grapes", "Banana" };

        // Ask the user to input text to search for in the list
        Console.WriteLine("\nStep I: Let's search for a fruit in the list!");
        Console.Write("Type the fruit you want to search for: ");
        string searchFruit = Console.ReadLine();

        // Assigment Step II -> Create a loop that iterates through the list and displays indices of matching items
        bool foundMatch = false; // Flag to track if at least one match is found

        for (int i = 0; i < fruitList.Count; i++)  // Loop through all items
        {
            // Check if the current list item matches the user's input
            if (fruitList[i].Equals(searchFruit, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Step II: Match found! '{fruitList[i]}' is at index {i}.");
                foundMatch = true; // Mark that a match was found and all matches will be displayed

            }
        }

        // Assigment Step III ---> Check if the user input was not found in the list
        if (!foundMatch)
        {
            Console.WriteLine($"Step III: Sorry, '{searchFruit}' is not on the list.");
        }

        // ----------------Assignment Part 5-----------------------------

        // Assigment Step I
        //Create a list of strings with duplicates
        List<string> letterList = new List<string> { "A", "B", "C", "D", "C", "B" };

        // Step II: Create a temporary list to keep track of items we've already seen
        List<string> seenItems = new List<string>();

        Console.WriteLine("\nStep II: Checking for duplicates in the list...");

        // Assigment Step II
        //Iterate through the list using foreach
        foreach (string item in letterList)
        {
            // Check if this item has already appeared in the seenItems list
            if (seenItems.Contains(item))
            {
                Console.WriteLine($"{item} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{item} - this item is unique");
                seenItems.Add(item); // Add the item to the seen list for future duplicate checks
            }
        }



        //----------------Assigment Part 2-----------------------------

        // Assigment Step I
        // Add a loop example
        //Console.WriteLine("Did you like the app? (yes/no)");
        //string userResponse = Console.ReadLine();
        // while(userResponse == "yes")

        //{
        //    // Infinite loop will print this message repeatedly. But we will fix it using "if" statement below.
        //    Console.WriteLine("Great! We're glad you liked it!");

        //}

        // Assigment Step II
        Console.WriteLine("Did you like the app? (yes/no)");
        string userResponse = Console.ReadLine();
        if (userResponse == "yes")
        {
            Console.WriteLine("Great! We're glad you liked it!");
        }
        else if (userResponse == "no")
        {
            Console.WriteLine("Thank you for your feedback! We'll strive to improve.");
        }
        else
        {
            Console.WriteLine("Invalid response. Please type 'yes' or 'no' next time.");
        }
    }
}
