using System;
class Person
{
    public string name;
    int age;
    int id;
    public Person()           // Default constructor
    {
        name = "Ratul";
        age = 30;
        id = 2320;
    }
    public Person(string Name, int Age, int Id)     // Parameterized Constructor
    {
        name = Name;
        age = Age;
        id = Id;
    }
    public Person(Person obj)     //  Copy Constructor
    {
        name = obj.name;
        age = obj.age;
        id = obj.id;
    }
    public void display()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age :" + age);
        Console.WriteLine("ID : " + id+"\n\n");
    }
}
class Program
{
    static void Main()
    {
        Person p1 = new Person();                    // Default constructor calling
        p1.display();

        Person p2 = new Person("Abeer",40,2320);     // Parameterized Constructor calling
        p2.display();

        Person p3 = new Person(p2);                  // Copy-Constructor calling
        p3.display();
    }
}