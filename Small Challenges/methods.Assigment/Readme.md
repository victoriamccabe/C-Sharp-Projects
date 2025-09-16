# Method Assignment

##  Assignment Requirements
1. **Create a class**  
   - In that class, create a void method that outputs an integer.  
   - Have the method divide the data passed to it by 2.  

2. **Use the "Main()" method**  
   - Instantiate the class.  
   - Have the user enter a number.  
   - Call the method on that number.  
   - Display the output to the screen.  

3. **Create a method with output parameters**  

4. **Overload a method**  

5. **Declare a class to be static**  

---

## Project Structure
"
methodAssigment/
│
├── Program.cs     # Entry point of the console app
├── Void.cs        # Contains the Void class with instance methods
└── Static.cs      # Contains the Static class with static methods
"

---

## How It Works

### 1. User Input  
The program asks the user to enter a number.

### 2. Void Method  
The "DivideByTwo()" method takes the input number, divides it by 2, and prints the result.

### 3. Output Parameter  
The "DivideWithOutput()" method uses an **output parameter** to return the division result.

### 4. Method Overloading  
The "OverloadExample()" method is **overloaded**:
- With an **int** parameter → multiplies by 10.  
- With a **double** parameter → divides by 100.  

### 5. Static Class  
The "Static" class contains a "MultiplyByTwo()" method that multiplies the number by 5 (even though its name says “Two”).  
- **Note:** A static class does not require creating an instance to call its methods.

---

##  Example Run

"
Enter a number:
20

20 divided by 2 = 10
Using output parameter: 20 divided by 2 = 10
Overloaded method (int): 200
Overloaded method (double): 0.2
Static method result: 100
"

---

## Concepts Practiced
- Classes and objects  
- Void methods  
- Output parameters ("out")  
- Method overloading  
- Static classes and methods  
