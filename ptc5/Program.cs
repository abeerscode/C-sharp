// Factorial of a number
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number :");
        int n = int.Parse(Console.ReadLine());

        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + n + " is : " + fact);
    }
}        