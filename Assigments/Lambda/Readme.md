# Lambda Expressions in C#

## Overview

This project demonstrates how to use **lambda expressions** and **LINQ** in C# to filter and query data from a list of employees.  
It compares a traditional `foreach` loop with modern lambda expressions to highlight the efficiency and readability of lambdas.

---

## Project Structure

* **Program.cs**

  * Creates a list of `Employee` objects.
  * Uses a `foreach` loop to filter employees by first name.
  * Uses lambda expressions to:

    * Find employees named **Joe**.
    * Find employees with **IDs greater than 5**.

  * Prints the results to the console.

* **Employee.cs**

  * Defines the `Employee` class with three properties:

    * Id (integer)
    * firstName (string)
    *`lastName (string)

---

## Key Concepts

* **`foreach` loop filtering**  
  Traditional method to filter data by iterating over each item.
* **Lambda expressions with LINQ**

  * `Where(x => x.firstName == "Joe")` → Finds all employees with the first name *Joe*.
  * `Where(x => x.Id > 5)` → Finds all employees with an ID greater than 5.

* **`.ToList()`**  
  Converts the LINQ query results into a list for iteration.

---

## Example Output

