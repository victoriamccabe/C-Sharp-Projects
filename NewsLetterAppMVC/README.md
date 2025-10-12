# NewsLetterAppMVC

A simple ASP.NET MVC application for managing newsletter sign-ups. Users can submit their information to join a newsletter, and administrators can view the list of sign-ups.

## Features

- User sign-up form for newsletter registration
- Stores user information in a SQL Server database
- Admin view to display all sign-ups

## Technologies

- ASP.NET MVC 5
- .NET Framework 4.7.2
- SQL Server (LocalDB)
- C#

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET Framework 4.7.2
- SQL Server LocalDB (installed with Visual Studio)

### Setup

1. **Clone the repository:**

2. **Open the solution:**
   - Open `NewsLetterAppMVC.sln` in Visual Studio.

3. **Database Setup:**
   - The project uses a LocalDB database file located in `App_Data`.
   - If the database does not exist, it will be created automatically on first run.
   - Ensure the connection string in `HomeController.cs` matches your environment if you encounter issues.

4. **Run the application:**
   - Press `F5` or click `Start` in Visual Studio.

## Project Structure

- `Controllers/` - MVC controllers for handling requests
- `Models/` - Data models
- `Views/` - Razor views for UI
- `App_Data/` - LocalDB database files

## Usage

- **Sign Up:**  
  Navigate to the home page and fill out the sign-up form.

- **Admin View:**  
  Go to `/Home/Admin` to see the list of all newsletter sign-ups.

## Troubleshooting

- If you encounter a database error (e.g., missing columns), verify the table schema matches the model properties.
- Update the connection string in `HomeController.cs` if your LocalDB instance uses a different name.

## License

This project is licensed under the MIT License.