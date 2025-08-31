# C# Console Program - Car Insurance Approval  

## Overview  
This program demonstrates basic input handling, logical operators, and decision-making in C#.  
It asks the user for their age, DUI history, and number of speeding tickets, then determines if the applicant qualifies for car insurance.  

## Features  
1. Prompts the user for their **age**.  
   - Applicant must be **over 15 years old** to qualify.  
2. Asks if the applicant has ever had a **DUI**.  
   - User must type "true" or "false".  
   - Applicants with any DUI history are disqualified.  
3. Asks how many **speeding tickets** the applicant has.  
   - Applicants must have **3 or fewer tickets** to qualify.  
4. Applies eligibility rules and prints a **True/False result** under "Qualified?".  

## Notes  
- The program uses "Convert.ToInt32()" for numeric input and "Convert.ToBoolean()" for boolean input.  
- If the user enters invalid data (e.g., letters instead of numbers or a word instead of "true"/"false"), the program will throw an error.  
- The output clearly states "Qualified?" followed by either "True" or "False".  