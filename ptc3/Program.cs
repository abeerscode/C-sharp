// Grading System
using System;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the score (0-100):");
            int score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                return;
            }

            string grade;
            if (score >= 80)
                grade = "A+";
            else if (score >= 75 && score < 80)
                grade = "A";
            else if (score >= 70 && score < 75)
                grade = "A-";
            else if (score >= 65 && score < 70)
                grade = "B+";
            else if (score >= 60 && score < 65)
                grade = "B";
            else if (score >= 55 && score < 60)
                grade = "B-";
            else if (score >= 50 && score < 55)
                grade = "C";
            else
                grade = "F";

            Console.WriteLine($"The grade for {score} is: {grade}");
        }
    }
}