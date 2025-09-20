# Day of the Week Console App

This is a simple C# console application that demonstrates the use of **enums**, **user input**, and **exception handling**. The program prompts the user to enter the current day of the week, validates the input, and displays the entered day.

---

## Features

- Uses a "DayOfWeek" enum to represent all days of the week.
- Continuously prompts the user until a valid day is entered.
- Handles invalid input gracefully using a "try/catch" block.
- Case-insensitive input parsing (e.g., "monday" or "Monday" works).

---

## How It Works

1. The program declares a variable of type "DayOfWeek"to store the user input.
2. A `while` loop runs until the user enters a valid day.
3. Inside the loop:
    - The user is prompted to enter the day.
    - The input is parsed into the "DayOfWeek" enum.
    - If parsing succeeds, the day is displayed and the loop exits.
    - If parsing fails, an error message is shown, and the loop repeats.
4. The program waits for the user to press a key before closing.