using System;
using System.Collections.Generic;

// ARRAYS AND LIST IN C# EXAMPLES
//class Program
//{
//    static void Main()
//    {
//        //-------------------------------
//        // LISTS
//        //-------------------------------
//        // Lists are like arrays, but they can grow and shrink as needed.

//        List<string> intList = new List<string>();
//        intList.Add("Hello");
//        intList.Add("Vicky");
//        intList.Remove("Vicky");

//        Console.WriteLine(intList[0]);
//        Console.ReadLine();





//        //-------------------------------
//        // ARRAYS
//        //-------------------------------
//        // In order to initialize an array, you must create a new INSTANCE of that array.
//        //int[] numArray = new int[5];
//        //numArray[0] = 5;
//        //numArray[1] = 2;
//        //numArray[2] = 10;
//        //numArray[3] = 200;
//        //numArray[4] = 5000;

//        // There is a easier way to create an array
//        int[] numArray2 = { 5, 2, 10, 200, 5000 };



//        Console.WriteLine(numArray2[2]); 
//        Console.ReadLine();

//    }
//}

class Program
{
    static void Main()
    {
        // Create an array of strings with colors
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple" };

        // Print array as a string
        Console.WriteLine("Available colors: " + string.Join(", ", colors));

        // Ask the user to select an index
        Console.WriteLine("Select an index between 0 and " + (colors.Length - 1) + " and I will print the color:"); // Subtract 1 from Length because array indexes start at 0, so the last valid index is Length - 1

        // Read input and convert it to an integer
        int index = Convert.ToInt32(Console.ReadLine());

        // Check if index is within range
        if (index >= 0 && index < colors.Length)
        {
            // Display the string at that index
            Console.WriteLine("You selected: " + colors[index]);
        }
        else
        {
            Console.WriteLine("Error: Index out of range.");
        }

        Console.WriteLine(""); // Blank line for readability

        // Create an array of integers with 5 elements
        int[] numbers = { 10, 20, 30, 40, 50 };
        
        // Print array as a string
        Console.WriteLine("Available numbers: " + string.Join(", ", numbers));

        // Ask the user to select an index
        Console.WriteLine("Select an index between 0 and " + (numbers.Length - 1) + ":");
        // Subtract 1 from Length because array indexes start at 0 so the last valid index is Length - 1

        // Read input and convert it to an integer
        int index2 = Convert.ToInt32(Console.ReadLine());

        // Check if index is within range
        if (index2 >= 0 && index2 < numbers.Length)
        {
            // Display the integer at that index
            Console.WriteLine("You selected number: " + numbers[index2]);
        }
        else
        {
            Console.WriteLine("Error: Index out of range.");
        }

        Console.WriteLine(""); // Blank line for readability

        // Create a list of strings with drinks

        // Create a list of drinks
        List<string> drinks = new List<string> { "Coffee", "Tea", "Juice", "Soda", "Water" };

        // Print array as a string
        Console.WriteLine("Available drinks: " + string.Join(", ", drinks));

        // Ask the user to select an index
        Console.WriteLine("Select an index between 0 and " + (drinks.Count - 1) + ":");
        // Subtract 1 from Count because list indexes start at 0 so the last valid index is Count - 1

        // Read input and convert it to an integer
        int index3 = Convert.ToInt32(Console.ReadLine());

        // Check if index is within range
        if (index3 >= 0 && index3 < drinks.Count)
        {
            // Display the drink at that index
            Console.WriteLine("You selected: " + drinks[index3] + "," + "Cheers !!");
        }
        else
        {
            Console.WriteLine("Error: Index out of range.");
        }

        Console.ReadLine();


    }
}

