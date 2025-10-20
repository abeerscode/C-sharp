using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an option");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1. Leap Year Check");
        Console.WriteLine("2. Prime Number Check");
        Console.WriteLine("3. Check Grade inserting marks");
        Console.WriteLine("4. Factorial of a Number");
        Console.WriteLine("5. Fibonacci of a Number");
        Console.WriteLine("6. Matrix");
        Console.WriteLine("7. Second largest number");

        Console.Write("\nEnter your choice (1-7): ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid input! Please enter a number.");
            return;
        }
    }
}