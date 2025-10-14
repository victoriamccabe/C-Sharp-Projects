# Student Registration App

## Overview

This is a **console application** built with **C#** and **Entity Framework Core (Code-First)** that demonstrates a basic database application. The program allows the user to **add students** to a SQL Server database and optionally **display all students** currently stored.

It is designed for **learning purposes** and demonstrates:

- EF Core Code-First approach
- Database creation and table mapping
- User input validation
- Exception handling
- Basic CRUD operations (Create & Read)

---

## Features

1. **Add Students**
   - The user is prompted to enter:
     - First Name (letters only, max 50 characters)
     - Last Name (letters only, max 50 characters)
     - Age (integer between 0 and 100)
   - Input is validated to prevent invalid data.
   - The student is saved into the `StudentDB` database using Entity Framework Core.

2. **Display Students**
   - After adding students, the user can choose to display all students stored in the database.
   - Shows `ID`, `First Name`, `Last Name`, and `Age`.

3. **Input Validation and Error Handling**
   - Ensures only valid data is entered for each field.
   - Uses `try-catch` blocks to handle invalid numeric input and database errors.

---

## Technologies Used

- C# 10 / .NET 6 Console Application
- Entity Framework Core 6
- SQL Server LocalDB
- Visual Studio 2022

---

## How to Run

1. Open the solution in **Visual Studio 2022**.
2. Make sure the following NuGet packages are installed:
   ```powershell
   Microsoft.EntityFrameworkCore
   Microsoft.EntityFrameworkCore.SqlServer

