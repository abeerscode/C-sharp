// Method or Function
using System;

class Employee
{
    private int employeeID = 123;
    private double salary;
    private string name = "Ratul";

    public void SetSalary(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Invalid Input, salary cannot be negative");
        }
        else
        {
            salary = amount;
        }
    }

    public double GetSalary()
    {
        return salary;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Id : " + employeeID);
        Console.WriteLine("Salary = " + salary);
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();

        e1.SetSalary(3000);
        e1.DisplayEmployeeInfo();

        Console.WriteLine("Salary via getter: " + e1.GetSalary());
    }
}