// Fibonacci Number 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter how many fibonacci number to display :");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci Series:");
        Console.Write(a + " " + b + " ");          //printing 0 and 1
        for (int i = 2; i < n; i++)                //loop starts from 2 because 0 and 1 are already printed    
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }    
}