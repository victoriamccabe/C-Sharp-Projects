using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Void.Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of the voidMethod class
            voidMethod vm = new voidMethod();
        
            // Ask user for a number
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Call the VoidMethod and pass a number to it
            vm.VoidMethod(number);

            Console.WriteLine($"Your number divided by 2 is: {result}");
            Console.ReadLine(); // Keeps console window open
        }
    }
}