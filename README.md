# BCEATS Meal Ordering System

## Overview
BCEATS is a C# console application designed for Belgium Campus to manage meal orders for students and lecturers.  
The system uses Object-Oriented Programming (OOP) principles and an Enum-based menu to ensure a clean, structured design.

## Features
- **Register Members:** Add both students and lecturers with relevant details.
- **View Registered Members:** Display all registered users.
- **Place an Order:** Assign a meal order to a registered student or lecturer.
- **View Orders:** List all placed orders.
- **Exit:** Close the application.

## Technologies
- **Language:** C#
- **Paradigm:** Object-Oriented Programming
- **Data Storage:** Collections (List<T>)
- **Concepts:** Enums, Inheritance, Loops, Conditional Statements, Methods

## Installation & Usage
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/BCEATS-Meal-Ordering-System.git
   ```
2. Open the solution in Visual Studio:
   ```plaintext
   BCEATS.sln
   ```
3. Build and run the program.

## Project Structure
- `Program.cs` → Main entry point with menu logic
- `Member`, `Student`, `Lecturer` → OOP model classes
- `Order` → Represents meal orders
- `MemberManager` / `OrderManager` → Handle CRUD operations
- `MenuOption` → Enum for menu items

## Contributors
- Oabusa Madubung

## License
This project is licensed under the MIT License.
