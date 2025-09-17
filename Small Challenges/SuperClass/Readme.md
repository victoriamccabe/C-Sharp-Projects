# C# Inheritance Project

## Assignment Requirements  
1. Create a class called "Person" and give it two properties of type "string":  
   - "FirstName"  
   - "LastName"  

2. Give this class a void method called "SayName()" that takes no parameters and writes the full name to the console in the format:  
   "My name is FirstName" + LastName"

3. Create another class called "Employee" that inherits from the "Person" class.  
   - Add a property called "Id" of type "int".  

4. In the "Main" method:  
   - Instantiate and initialize an "Employee" object with a first name of "Sample" and a last name of "Student".  
   - Call the superclass method "SayName()" on the "Employee" object.  

5. Add "comments" to each line or block of your code to explain what it does, so another developer can understand it.


## Project Structure  
"Person.cs" → Contains the Person class with FirstName, LastName, and SayName().  
"Employee.cs" → Contains the Employee class inheriting from Person with Id property.  
"Program.cs" → Contains the Main method that creates and runs the Employee object.  

