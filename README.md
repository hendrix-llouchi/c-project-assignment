# Student Results Processing System

A C# Console Application designed to process and report student results. This project was developed as part of **Programming with C# Assignment 1**.

## Student Details
- **Name:** Cobbinah Henry
- **Index Number:** SRI.41.008.080.23
- **Class:** CE 300 A
- **Date:** June 24, 2026

---

## Features
- **Enter Student Results:** Accepts student details such as Name, Student ID, Programme, Level, and scores for 5 courses (with validation to ensure score values are between 0 and 100).
- **Automated Calculations:** Computes the total score, average score, alphabetical grade, and passing status dynamically.
- **View Student Report:** Displays a formatted summary of all entered student records.
- **Interactive Menu:** Simple console-based interface for easy navigation.

---

## Grade & Status Schema
The system evaluates average scores based on the following criteria:

| Average Score Range | Grade | Status |
|---|---|---|
| 80 - 100 | A | Passed |
| 75 - 79.9 | B+ | Passed |
| 70 - 74.9 | B | Passed |
| 65 - 69.9 | C+ | Passed |
| 60 - 64.9 | C | Passed |
| 55 - 59.9 | D+ | Passed |
| 50 - 54.9 | D | Passed |
| Below 50 | F | Failed |

---

## Requirements
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or later, compatible with .NET 10.0)

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/hendrix-llouchi/c-project-assignment.git
   ```
2. Navigate to the project directory:
   ```bash
   cd c-project-assignment
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. Build the project:
   ```bash
   dotnet build
   ```