# taller1PPO

## Project Description
This project is a C# console application developed for the PPO workshop.

It implements a `Time` class with:
- Private fields for hour, minute, second, and millisecond
- Read-only properties
- Multiple constructors (overloads)
- Time conversion methods
- Time addition logic
- Validation methods for hour, minute, second, and millisecond
- Custom string formatting in 12-hour format with AM/PM

The `Program.cs` file tests different `Time` objects and prints the results in the console.

---

## Files Included
- `Program.cs` → Main program that tests the `Time` class
- `Time.cs` → Implementation of the `Time` class
- `taller1PPO.csproj` → Project file
- `taller1PPO.sln` → Solution file
- `ClassDiagram1.cd` → Class diagram for the `Time` class

---

## How to Run the Project

### Option 1: Visual Studio
1. Open `taller1PPO.sln` in Visual Studio
2. Build the project
3. Run with:
   - `Ctrl + F5` (recommended, keeps console open)
   - or `F5` (debug mode)

### Option 2: .NET CLI
Open a terminal in the project folder and run:

```bash
dotnet run
