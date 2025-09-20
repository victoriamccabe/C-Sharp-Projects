using Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;


namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Instantiate an Employee object with string as the generic type.
            Employee<string> stringEmployee = new Employee<string>
            {
                Things = new List<string> { "Laptop", "Notebook", "Pen" } // List of strings
            };

            // Instantiate an Employee object with int as the generic type
            Employee<int> intEmployee = new Employee<int>
            {
                Things = new List<int> { 1, 4, 50 }
            };

            // Loop that prints out the Things property of both Employee objects.
            Console.WriteLine("Employee Things with quantities:");
            for (int i = 0; i < stringEmployee.Things.Count; i++)
            {
                Console.WriteLine($"{stringEmployee.Things[i]} quantity: {intEmployee.Things[i]}");
            }
        }
    }
}