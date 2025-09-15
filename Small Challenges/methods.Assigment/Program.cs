using System;


namespace methodAssigment
{
    class Program
    {
     
            // Main() is where the program starts running
            static void Main(string[] args)
            {
                // Ask the user to type a number
                Console.WriteLine("Enter a number:");

                // Convert the input string to an integer
                int number = Convert.ToInt32(Console.ReadLine());

                // Instance of the Void class
                Void vm = new Void();

                // Call the DivideByTwo method and pass in the number (This method will print the result to the screen)
                vm.DivideByTwo(number);

                // Use a method with an output parameter
                int result;
                vm.DivideWithOutput(number, out result); // 'out result' will receive the answer
                Console.WriteLine($"Using output parameter: {number} divided by 2 = {result}");

                // Call overloaded methods (same method name, different parameters)
                Console.WriteLine($"Overloaded method (int): {vm.OverloadExample(number)}");
            Console.WriteLine($"Overloaded method (double): {vm.OverloadExample((double)number)}");

            // Use a static class method (no object needed)
            Console.WriteLine($"Static method result: {Static.MultiplyByTwo(number)}");
            }
        }
    }

       
