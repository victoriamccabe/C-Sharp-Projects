using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic; // Lets us use Lists, Dictionaries, etc.
using System.Linq;                // Useful for queries 
using System.Threading.Tasks;     // Used for async tasks 
using System.Text;                // Useful for string handling 
using System.IO;                  // Used for file input/output 
using Casino;
using Casino.TwentyOne;                    // Reference to the Casino namespace
// ----------------------------------------------------------------
// THIS CODE IS FULLY COMMENTED FOR LEARNING PURPOSES
// ----------------------------------------------------------------

// A namespace is like a container for related classes
namespace TwentyOne
{
    class Program
    {
        // The entry point of the program
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's stat by telling me your name.");
            string playerName = Console.ReadLine(); // Read the player's name from console input
            if (playerName.ToLower() == "admin") // Check if the player is an admin
            {
                List<ExceptionEntity> Exceptions = ReadExceptions(); // Read all the exceptions from the database
                foreach (var exception in Exceptions) // Loop through each exception and display its details
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine(); // Wait for user input before closing
                return; // Exit the program
            }

            bool validAnswer = false; // Initialize a boolean variable to track if the answer is valid
            int bank = 0; // Initialize a variable to hold the player's bank amount
            while (!validAnswer) // Loop until a valid answer is provided
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); // Try to parse the input as an integer
                if (!validAnswer) // If parsing fails, inform the user
                {
                    Console.WriteLine("Please enter digits only. No decimals.");
                }
            }


            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); // Read and convert the answer to lowercase

            // Check if the player wants to play
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); // Create a new Player object and initialize it with name and bank

                // Generate a unique identifier for the player
                player.Id = Guid.NewGuid(); // Assign a new unique identifier to the player--this is useful for tracking players in a database
                // Log the player's ID to a file
                using (StreamWriter file = new StreamWriter(@"C:\Users\victo\Repos\C-Sharp-Projects\TwentyOne\log.txt", true)) // Create a StreamWriter to log player activity to a file
                {
                    file.WriteLine(player.Id); // Log the player's unique identifier
                }
                Game game = new TwentyOneGame(); // Create a new instance of the TwentyOneGame class
                game += player; // Adding player to the game using overloaded + operator
                player.isActivelyPlaying = true; // Set the player's active status to true

                // Loop while the player is active and has money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play(); // Start the game
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; // Exit the program
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        UpdateDbWithException(ex); // Log the exception to the database
                        Console.ReadLine();
                        return; // Exit the program
                    }


                }
                game -= player; // Remove player from the game using overloaded - operator
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }

        // Placeholder method for updating the database with exception details
        [Obsolete]
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Connection string for the database
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)"; // SQL query to insert exception details

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(queryString, connection))
            {
                command.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar, 50).Value = ex.GetType().ToString();
                command.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar, 200).Value = ex.Message;
                command.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to read exceptions from the database if the player's name is "admin"
        [Obsolete]
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Connection string for the database
            
            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions"; // SQL query to select exception details
            
            
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>(); // Initialize a list to hold the exceptions

            
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString)) // Create a new SQL connection
            using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(queryString, connection)) // Create a new SQL command
            {
                connection.Open(); // Open the database connection
                SqlDataReader reader = command.ExecuteReader(); // Execute the query and get a data reader

                // Loop through each record in the data reader
                while (reader.Read()) 
                {
                    ExceptionEntity exception = new ExceptionEntity(); // Create a new ExceptionEntity object
                    exception.Id = Convert.ToInt32(reader["Id"]); // Read and convert the Id field
                    exception.ExceptionType = reader["ExceptionType"].ToString(); // Read the ExceptionType field
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString(); // Read the ExceptionMessage field
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]); // Read and convert the TimeStamp field
                    Exceptions.Add(exception); // Add the exception to the list
                }
                connection.Close(); // Close the database connection
            }
            return Exceptions; // Return the list of exceptions
        }
    }
}