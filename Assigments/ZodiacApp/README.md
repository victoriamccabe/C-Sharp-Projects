# ZodiacApp

A simple **C# Console Application** that asks the user for their name and birth date, then calculates and displays their **Western Zodiac sign**.

This repository is intended as a classroom-ready example that demonstrates three C# features:

- "const" variables  
- "var" type inference  
- **Constructor chaining** (one constructor calling another)

---

##  Project structure

""
ZodiacApp/
├── Program.cs        # Entry point: user I/O, uses const and var
├── Person.cs         # Person class: constructor chaining; stores user data + zodiac
└── ZodiacHelper.cs   # Static helper: determines zodiac sign from day/month
""

---

##  Features explained

- **Const variable**  
  Program.cs contains a constant greeting that cannot be changed at runtime:
  ""
  const string Greeting = "Welcome to the Zodiac Sign Finder!";
  ""

- **"var" keyword**  
  "var" is used to let the compiler infer the type:
  ""
  var today = DateTime.Now; // inferred as DateTime
  ""

- **Constructor chaining**  
  Person class chains constructors so the 3-parameter constructor reuses the 1-parameter constructor:
  ""
  public Person(string name) { Name = name; }
  public Person(string name, int day, int month) : this(name)
  {
      Day = day;
      Month = month;
      ZodiacSign = ZodiacHelper.GetZodiacSign(day, month);
  }
  ""

---

##  How it works

1. Program prints a greeting (the "const").  
2. Program shows the current date (using "var" inferred "DateTime").  
3. Program asks the user for:  
   - Name  
   - Day of birth (1–31)  
   - Month of birth (1–12)  
4. A "Person" object is created using the constructor that chains to the name-only constructor.  
5. "ZodiacHelper.GetZodiacSign(day, month)" determines the Western zodiac sign.  
6. Program prints the result.  

---

##  Example run

""
Welcome to the Zodiac Sign Finder!
Today's date: 10/03/2025
Enter your name: Alice
Enter your day of birth (1-31): 15
Enter your month of birth (1-12): 6

Hello Alice!
Your Zodiac Sign is: Gemini
""

---

##  Build & run

1. Open the project folder "ZodiacApp" in Visual Studio, Visual Studio Code (with C# extension), or another C# IDE.  
2. Make sure you have the .NET SDK installed (any modern .NET Core / .NET 5+ will work).  
3. Build the project.  
4. Run the console application and follow the prompts.  


##  Files

- **Program.cs** — Application entry point. Demonstrates "const" and "var".  
- **Person.cs** — Contains "Person" class with constructor chaining.  
- **ZodiacHelper.cs** — Static helper class to calculate zodiac sign from day and month.  

---

##  Notes

- Input validation is minimal; invalid values may cause errors.  
- Zodiac logic follows common Western astrology date ranges.  
- Extendable: you can add year of birth and compute **Chinese Zodiac** as well.  

---
