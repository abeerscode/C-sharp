using System;
class Rectangle
{
    private int length;
    private int width;
    private int area;
    public int Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value <= 0)
            {
                Console.Write("Invalid input");
            }
            else
            {
                length = value;
            }
        }
    }
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value <= 0)
            {
                Console.Write("Invalid input");
            }
            else
            {
                width = value;
            }
        }
    }
    public int Area
    {
        get
        {
            return length * width;
        }
    }
}
class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        r1.Length = 3;
        r1.Width = 4;
        Console.Write("Area is : " + r1.Area);
    }
}