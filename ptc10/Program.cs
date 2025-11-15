using System;

class Car
{
    public string model, color;
    public int tyre, price;
    
    public void get_data()
    {
        Console.Write("Enter car model: ");
        model = Console.ReadLine();
        Console.Write("Enter car color: ");
        color = Console.ReadLine();
        Console.Write("Number of tyres: ");
        tyre = int.Parse(Console.ReadLine());
        Console.Write("Enter car price: ");
        price = int.Parse(Console.ReadLine());
    }
    
    public void print_data()
    {
        Console.WriteLine("Car model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Number of tyres: " + tyre);
        Console.WriteLine("Price: " + price);
    }
}

class Program
{
    static void Main()
    {
        Car c1 = new Car();
        c1.get_data();
        c1.print_data();
    }
}
