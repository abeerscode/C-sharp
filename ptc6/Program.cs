using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an option");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Leap Year Check");
        Console.WriteLine("2. Prime Number Check");
        Console.WriteLine("3. Check Grade inserting marks");
        Console.WriteLine("4. Factorial of a Number");
        Console.WriteLine("5. Fibonacci of a Number");

        Console.Write("\nEnter your choice (1-5): ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid input! Please enter a number.");
            return;
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter a year:");
                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.WriteLine("Invalid input! Please enter a valid year.");
                    return;
                }
                
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
                break;

            case 2:
                Console.WriteLine("Check Prime number");
                Console.WriteLine("------------------------");
                Console.Write("Enter a number (positive integer): ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    return;
                }

                bool isPrime = true;

                if (number <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                Console.WriteLine(isPrime
                    ? $"{number} is a prime number."
                    : $"{number} is not a prime number.");
                break;

            case 3:
                Console.WriteLine("Check Grade inserting marks");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter the score (0-100):");
                if (!int.TryParse(Console.ReadLine(), out int score))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    return;
                }

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    return;
                }

                string grade = score switch
                {
                    >= 80 => "A+",
                    >= 75 => "A",
                    >= 70 => "A-",
                    >= 65 => "B+",
                    >= 60 => "B",
                    >= 55 => "B-",
                    >= 50 => "C",
                    _ => "F"
                };

                Console.WriteLine($"The grade for {score} is: {grade}");
                break;

            case 4:
                Console.WriteLine("Calculate Factorial");
                Console.WriteLine("------------------------");
                Console.Write("Enter a non-negative integer: ");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    return;
                }
                
                if (num < 0)
                {
                    Console.WriteLine("Factorial is not defined for negative numbers.");
                    return;
                }
                
                long factorial = 1;
                for (int i = 2; i <= num; i++)
                {
                    factorial *= i;
                }
                
                Console.WriteLine($"Factorial of {num} is: {factorial}");
                break;

            case 5:
                Console.WriteLine("Calculate Fibonacci");
                Console.WriteLine("------------------------");
                Console.Write("Enter the number of terms: ");
                if (!int.TryParse(Console.ReadLine(), out int terms))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    return;
                }
                
                if (terms < 1)
                {
                    Console.WriteLine("Please enter a positive number.");
                    return;
                }
                
                Console.WriteLine("Fibonacci Series:");
                int first = 0, second = 1;
                
                for (int i = 1; i <= terms; i++)
                {
                    Console.Write($"{first} ");
                    int next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Invalid choice! Please select a number between 1 and 5.");
                break;
        }
    }
}