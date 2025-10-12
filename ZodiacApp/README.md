# ZodiacApp

A simple C# console application that determines a user's Zodiac sign based on their birth date.

## Features

- Prompts the user for their name and birth date.
- Calculates and displays the user's Zodiac sign.
- Demonstrates C# features such as:
  - `const` variables
  - Type inference with `var`
  - Constructor chaining
  - Static helper classes
  - Pattern matching with `switch` expressions (C# 8+)
- Built with .NET 8 and C# 12.

## How It Works

1. The application greets the user and asks for their name, day, and month of birth.
2. It creates a `Person` object, which uses the `ZodiacHelper` class to determine the Zodiac sign.
3. The result is displayed to the user.

## Example run

```
Welcome to the Zodiac Sign Finder!
Today's date: 10/03/2025
Enter your name: Alice
Enter your day of birth (1-31): 15
Enter your month of birth (1-12): 6

Hello Alice!
Your Zodiac Sign is: Gemini
```

## Build & run

1. Open the project folder "ZodiacApp" in Visual Studio, Visual Studio Code (with C# extension), or another C# IDE.
2. Make sure you have the .NET SDK installed (any modern .NET Core / .NET 5+ will work).
3. Build and run the application:

## Files

- **Program.cs** — Application entry point. Demonstrates "const" and "var".
- **Person.cs** — Contains "Person" class with constructor chaining.
- **ZodiacHelper.cs** — Static helper class to calculate zodiac sign from day and month.

## Notes

- Input validation is minimal; invalid values may cause errors.
- Zodiac logic follows common Western astrology date ranges.
- Extendable: you can add year of birth and compute **Chinese Zodiac** as well.
