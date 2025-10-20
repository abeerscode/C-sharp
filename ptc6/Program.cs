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

        switch (choice)
        {
            case 1:
                Console.Write("Enter a year: ");
                if (!int.TryParse(Console.ReadLine(), out int year)) { Console.WriteLine("Invalid year"); break; }
                Console.WriteLine(((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? $"{year} is a leap year." : $"{year} is not a leap year.");
                break;

            case 2:
                Console.Write("Enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out int number)) { Console.WriteLine("Invalid number"); break; }
                if (number <= 1) { Console.WriteLine($"{number} is not a prime number."); break; }
                bool prime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++) if (number % i == 0) { prime = false; break; }
                Console.WriteLine(prime ? $"{number} is prime." : $"{number} is not prime.");
                break;

            case 3:
                Console.Write("Enter the score (0-100): ");
                if (!int.TryParse(Console.ReadLine(), out int score)) { Console.WriteLine("Invalid score"); break; }
                if (score < 0 || score > 100) { Console.WriteLine("Score must be between 0 and 100"); break; }
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
                Console.Write("Enter a non-negative integer: ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n < 0) { Console.WriteLine("Invalid number"); break; }
                long fact = 1;
                for (int i = 2; i <= n; i++) fact *= i;
                Console.WriteLine($"Factorial of {n} is {fact}");
                break;

            case 5:
                Console.Write("Enter the number of Fibonacci terms: ");
                if (!int.TryParse(Console.ReadLine(), out int terms) || terms < 1) { Console.WriteLine("Invalid number of terms"); break; }
                int a = 0, b = 1;
                Console.WriteLine("Fibonacci Series:");
                for (int i = 0; i < terms; i++)
                {
                    Console.Write(a + (i < terms - 1 ? " " : "\n"));
                    int tmp = a + b; a = b; b = tmp;
                }
                break;

            case 6:
                Console.Write("Enter number of rows: ");
                if (!int.TryParse(Console.ReadLine(), out int rows) || rows < 1) { Console.WriteLine("Invalid rows"); break; }
                Console.Write("Enter number of columns: ");
                if (!int.TryParse(Console.ReadLine(), out int cols) || cols < 1) { Console.WriteLine("Invalid columns"); break; }
                int[,] arr = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        if (!int.TryParse(Console.ReadLine(), out int elem)) { Console.WriteLine("Invalid element"); return; }
                        arr[i, j] = elem;
                    }
                Console.WriteLine($"\nThe {rows}x{cols} matrix is:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++) Console.Write(arr[i, j] + "\t");
                    Console.WriteLine();
                }
                break;

            case 7:
                Console.Write("How many numbers? ");
                if (!int.TryParse(Console.ReadLine(), out int count) || count < 2) { Console.WriteLine("Need at least two numbers"); break; }
                int[] nums = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter number #{i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out nums[i])) { Console.WriteLine("Invalid number"); return; }
                }
                int max1 = int.MinValue, max2 = int.MinValue;
                foreach (var v in nums)
                {
                    if (v > max1) { max2 = max1; max1 = v; }
                    else if (v > max2 && v != max1) max2 = v;
                }
                if (max2 == int.MinValue) Console.WriteLine("There is no distinct second largest value.");
                else Console.WriteLine($"Second largest number is: {max2}");
                break;

            default:
                Console.WriteLine("Invalid choice. Choose 1-7.");
                break;
        }
    }
}