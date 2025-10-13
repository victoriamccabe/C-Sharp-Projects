# C-Sharp-Projects Solution

A collection of C# projects demonstrating core .NET 8 features, including Razor Pages, console applications, and Entity Framework Core. This solution is designed for learning, experimentation, and practical demonstration of modern C# and .NET development.

---

## Projects Included

### 1. CarInsurance (Razor Pages Web App)
- **Type:** ASP.NET Core Razor Pages (.NET 8)
- **Purpose:** Manage car insurance quotes and insuree information.
- **Features:**
  - Add, edit, and delete insuree records
  - Calculate insurance quotes based on user input
  - Entity Framework Core with SQL database
  - Razor Pages architecture for clean separation of concerns

### 2. Math Challenge (Console App)
- **Type:** Console Application (.NET 8)
- **Purpose:** Prompts the user for their name and birth date, then calculates and displays their Zodiac sign.
- **Features:** Demonstrates use of `const`, type inference, constructor chaining, static helper classes, and pattern matching.

### 3. UserInputAndMath (Console App)
- **Type:** Console Application (.NET 8)
- **Purpose:** Demonstrates basic input, output, and arithmetic operations.
- **Features:** Multiplies, adds, divides, and checks user input with various math operations.

### 4. Optional Parameter Math App (Console App)
- **Type:** Console Application (.NET 8)
- **Purpose:** Demonstrates the use of optional parameters in C# methods.
- **Features:** Accepts one or two numbers, performs addition, and prints the result.

### 5. MethodSubmission.Assignment (Console App)
- **Type:** Console Application (.NET 8)
- **Purpose:** Contains a class with three math methods, each performing a different operation on an integer.
- **Features:** User input, method calls, and clear output with code comments.

---

## Getting Started

1. **Clone the repository:**
2. **Open the solution in Visual Studio 2022.**
3. **Restore NuGet packages** if prompted.
4. **Build the solution** to ensure all projects compile.
5. **Run the desired project:**
- Right-click the project in Solution Explorer and select `Set as Startup Project`.
- Press `F5` or use the Visual Studio run button.

---

## Technologies Used

- .NET 8
- ASP.NET Core Razor Pages
- Entity Framework Core
- C# 12
- SQL Server (localdb or as configured)
- Console Applications

---

## Notes

- Each project is self-contained and can be run independently.
- For web projects, ensure your database connection string in `appsettings.json` is correct.
- Migrations are included for easy database setup in Entity Framework Core projects.
- These projects are intended for educational purposes and can be extended for production use.

---