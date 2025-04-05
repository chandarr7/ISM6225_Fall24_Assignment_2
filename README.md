# ISM6225 Fall 2024 Assignment 2: Computational Problem Solving

## Overview

This repository contains my solution for Assignment 2 for the ISM6225 Fall 2024 course. In this assignment, I implemented eight computational problems in C# using the provided starter repository. I made sure to handle various edge cases, add detailed inline comments, and document all the GitHub Copilot assistance I used in a separate file named `prompts.docx`.

## Problems Implemented

1. **Find Missing Numbers in Array**  
   Given an array containing numbers from 1 to *n* (with possible duplicates), this function identifies which numbers are missing from the sequence.

2. **Sort Array by Parity**  
   This function rearranges an array so that all even numbers appear before all odd numbers.

3. **Two Sum**  
   For an array of integers and a target value, this function returns the indices of the two numbers whose sum equals the target. It utilizes a dictionary-based approach for efficient lookups.

4. **Find Maximum Product of Three Numbers**  
   This function finds the three numbers in the array that have the maximum product. It handles both positive and negative values by sorting the array and comparing different product combinations.

5. **Decimal to Binary Conversion**  
   Converts a given decimal number into its binary string representation using an iterative method.

6. **Find Minimum in Rotated Sorted Array**  
   Using a modified binary search, this function finds the minimum element in a rotated sorted array.

7. **Palindrome Number**  
   Determines if an integer is a palindrome (reads the same forward and backward) by reversing the number and comparing it to the original. Negative numbers are not considered palindromes.

8. **Fibonacci Number**  
   Computes the nth Fibonacci number using an iterative approach, efficiently handling the base cases.

## Project Structure

- **Program.cs**  
  Contains the complete C# code with inline comments explaining the logic and edge-case handling for each problem.

- **prompts.docx**  
  A document that details all the GitHub Copilot AI assistance. It includes:
  - The prompts I used.
  - The responses I received.
  - How I integrated the suggested code.
  - Any adjustments I made to the solutions.

- **output.png**  
  A screenshot of the console output showing that all methods are executed successfully with the expected results.

- **README.md**  
  This file.

## How to Build and Run

1. **Clone the Repository**

   Open your terminal or Git Bash and run:

   ```bash
   git clone https://github.com/chandarr7/ISM6225_Fall24_Assignment_2.git
   cd ISM6225_Fall24_Assignment_2
Build the Project

Run the following command in your terminal or use Visual Studio’s Build menu:
dotnet build
Run the Project

After a successful build, execute:dotnet run
<img width="468" alt="image" src="https://github.com/user-attachments/assets/0ae33dd0-2bc0-4aed-830e-5841d26d2f64" />

