// second largest number
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        // Check for at least two elements
        if (size < 2)
        {
            Console.WriteLine("Array must have at least two elements.");
            return;
        }

        int[] arr = new int[size];
        int largest, sec_largest;

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Initialize largest and sec_largest
        if (arr[0] > arr[1])
        {
            largest = arr[0];
            sec_largest = arr[1];
        }
        else
        {
            largest = arr[1];
            sec_largest = arr[0];
        }

        // Loop to find the second largest
        for (int i = 2; i < size; i++)
        {
            if (arr[i] > largest)
            {
                sec_largest = largest;
                largest = arr[i];
            }
            else if (arr[i] > sec_largest && arr[i] != largest)
            {
                sec_largest = arr[i];
            }
        }
        Console.WriteLine("Largest number is: " + largest);
        Console.WriteLine("Second largest number is: " + sec_largest);
    }
}