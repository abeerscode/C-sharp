using System;
class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit) 
        {
            Console.Clear(); 

            Console.WriteLine("Select an option");
            Console.WriteLine("1. Find largest number");
            Console.WriteLine("2. Second largest number");
            Console.WriteLine("3. Matrix");
            Console.WriteLine("4. Check grade");
            Console.WriteLine("5. Fibonacci Number");
            Console.WriteLine("6. Factorial of a number");
            Console.WriteLine("7. Check grade");
            Console.WriteLine("8. Exit");

            Console.Write("\nEnter your choice: ");
            string num = Console.ReadLine();

            switch(num)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Largest number logic here...");
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Second largest number logic here...");
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Matrix logic here...");
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Grade logic here...");
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Fibonacci logic here...");
                    break;

                case "6":
                    Console.Clear();
                    Console.WriteLine("Factorial logic here...");
                    break;

                case "7":
                    Console.Clear();
                    Console.WriteLine("Grade logic here...");
                    break;

                case "8":
                    Console.Clear();
                    exit = true;   
                    continue;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;      
            }

            
            while (true)
            {
                Console.WriteLine("\n\nWhat do you want next");
                Console.WriteLine("1. Go back to menu");
                Console.WriteLine("2. Exit");

                string next = Console.ReadLine();

                
                if (next == "1") 
                {
                    break; 
                }
                else if (next == "2")
                {
                    exit = true; 
                    break;       
                }
                else
                {
                    Console.WriteLine("Invalid Choice.");
                    continue; 
                }
            }
        }

        Console.WriteLine("Program Ended ✅");
    }
}