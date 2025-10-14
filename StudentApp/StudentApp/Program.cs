using System;
using System.Linq;

namespace StudentApp
{
    class Program
    {
        static void Main()
        {
            using (var context = new SchoolContext())
            {
                context.Database.EnsureCreated();

                
                Console.WriteLine(" Welcome to the Student Registration App ");
                Console.WriteLine("\n");

                bool addMore = true;

                while (addMore)
                {
                    string firstName = "";
                    string lastName = "";
                    int age = -1;

                    // Get and validate first name
                    while (true)
                    {
                        Console.Write("Enter first name (letters only): ");
                        firstName = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(firstName) &&
                            firstName.Length <= 50 &&
                            firstName.All(c => char.IsLetter(c)))
                        {
                            break; // Valid input
                        }
                        Console.WriteLine("Invalid first name! Please try again.\n");
                    }

                    // Get and validate last name
                    while (true)
                    {
                        Console.Write("Enter last name (letters only): ");
                        lastName = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(lastName) &&
                            lastName.Length <= 50 &&
                            lastName.All(c => char.IsLetter(c)))
                        {
                            break; // Valid input
                        }
                        Console.WriteLine("Invalid last name! Please try again.\n");
                    }

                    // Get and validate age
                    while (true)
                    {
                        Console.Write("Enter age (0-100): ");
                        string input = Console.ReadLine();

                        try
                        {
                            age = int.Parse(input);
                            if (age >= 0 && age <= 100)
                            {
                                break; // Valid age
                            }
                            else
                            {
                                Console.WriteLine("Age must be between 0 and 100!\n");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input! Please enter a number.\n");
                        }
                    }

                    // Create student object
                    var student = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age
                    };

                    // Add to database with try-catch
                    try
                    {
                        context.Students.Add(student);
                        context.SaveChanges();
                        Console.WriteLine($"\nStudent {firstName} {lastName} added successfully!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving student: {ex.Message}\n");
                    }

                    // Ask if user wants to add another student
                    Console.Write("Do you want to add another student? (y/n): ");
                    string response = Console.ReadLine().ToLower();
                    addMore = response == "y";
                    Console.WriteLine();
                }

                // Display all students
                Console.Write("Do you want to display all students in the database? (y/n): ");
                string displayResponse = Console.ReadLine().ToLower();
                if (displayResponse == "y")
                {
                    var students = context.Students.ToList();

                    Console.WriteLine("\nList of all students:");
                    Console.WriteLine("---------------------");
                    foreach (var s in students)
                    {
                        Console.WriteLine($"ID: {s.Id}, Name: {s.FirstName} {s.LastName}, Age: {s.Age}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Thank you for using the Student Registration App!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}