# COUNTING AND GUESSING GAME

## Assignment
This project was created based on the following assignment instructions:

- Do a boolean comparison using a while statement.  
- Do a boolean comparison using a do while statement.  
- Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.  

---

## Project Overview
This project is a "C# console application" created to practice "while" and "do-while" loops with boolean comparisons.  
The program has two parts:  
1. It uses a "while loop" to count from 0 to 20 with a short pause between numbers.  
2. It uses a "do-while loop" to create a simple number guessing game where the user has up to 3 attempts to guess a secret random number.

---

## Requirements
The application must:

1. Print an introduction message and count from "0 to 20" using a "while" loop.  
2. Pause briefly between each count so the output is easier to read.  
3. Randomly generate a number between "0 and 20".  
4. Ask the user to guess the secret number.  
5. Allow the user "3 attempts" to guess correctly.  
6. Use a "do-while" loop to control the guessing attempts.  
7. Display appropriate messages for:  
   - Correct guess  
   - Wrong guess  
   - Invalid input (non-numeric values)  
   - Game over (with the secret number revealed if not guessed)  
8. Include comments explaining each line or block of code.

---

## How It Works
1. The program greets the user and starts counting from "0 to 20" using a "while" loop.  
2. After finishing the count, the program switches to the guessing game.  
3. A random number between "0 and 20" is chosen secretly.  
4. The user enters guesses until they either:  
   - Guess the number correctly, or  
   - Use all 3 attempts.  
5. The program ends by displaying whether the user won or lost, and then thanks them for playing.  

---
## Example Run
"I am going to count to 20  
0  
1  
2  
...  
20  

I picked a number between 0 and 20.  
You have 3 attempts to guess it!  
Enter your guess: 10  
Wrong guess, try again!  
Enter your guess: 5  
Wrong guess, try again!  
Enter your guess: 15  
Correct! You guessed the number!  
Game over. Thanks for playing!"  

---

## Getting Started
1. Clone or download this repository.  
2. Open the project in "Visual Studio" or any C# editor.  
3. Build and run the program.  
4. Follow the instructions in the console window to try the counting and guessing game.  