# CarInsurance

A Razor Pages web application for managing car insurance quotes and insuree information.

## Overview

This project allows users to create, view, and manage car insurance quotes. It demonstrates the use of Razor Pages, Entity Framework Core, and .NET 8 features in a real-world scenario.

## Features

- Add, edit, and delete insuree records
- Calculate insurance quotes based on user input
- Store data using Entity Framework Core with a SQL database
- Follows the Razor Pages pattern for clean separation of concerns

## Project Structure

- **Models/** — Contains the `Insuree` model and `InsuranceContext` for EF Core.
- **Migrations/** — Database migration files for schema management.
- **Controllers/** — Handles HTTP requests for insuree operations.
- **appsettings.json** — Configuration for database connection and app settings.
- **Program.cs** — Application startup and configuration.

## Getting Started

1. **Clone the repository:**
2. **Open the solution in Visual Studio 2022.**
3. **Update the database:**
   - Open the Package Manager Console and run:
     ```
     Update-Database
     ```
4. **Run the application:**
   - Press `F5` or use the Visual Studio run button.

## Usage

- Navigate to the Insurees page to add or manage records.
- Enter the required information to generate a quote.
- Edit or delete existing insuree records as needed.

## Technologies Used

- .NET 8
- Razor Pages
- Entity Framework Core
- SQL Server (localdb or configured in `appsettings.json`)

## Notes

- Ensure your connection string in `appsettings.json` is correct for your environment.
- Migrations are included for easy database setup.
- This project is intended for educational purposes and can be extended for production use.