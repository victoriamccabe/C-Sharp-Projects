# Abstract Class and Inheritance

## Objective
This project demonstrates how to use abstract classes, inheritance, and method overriding in C#.  

## Description
- An abstract class "Person" is created with two properties: "firstName" and "lastName".  
- The abstract method "SayName()" is defined in the "Person" class.  
- A class "Employee" inherits from "Person" and implements the "SayName()" method.  
- In the "Main()" method, an "Employee" object is instantiated with "firstName = Sample" and "lastName = Student".  
- The "SayName()" method is called to display the full name of the employee.  

## Project Structure

/Abstract.Assigment  
- Program.cs        
Main entry point  
- Person.cs        
Abstract class with properties + abstract method  
- Employee.cs
Derived class that inherits from Person  


## Key Concepts
- "abstract" keyword is used to declare a class or method that must be implemented in a derived class.  
- "override" keyword is used to provide a specific implementation of an inherited abstract method.  
- Objects are created using "new".  
- Properties hold data, and methods define actions for a class.  
