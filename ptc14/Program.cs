/*
Design a C# program to model a Smart Garden Management
System using inheritance. Create a base class named
GardenDevice with the following:
# Properties: Name, Brand, and PowerUsage.
# Method: Operate() that displays the message:
   "Each garden device operates in its own way."
Derive the following subclasses from GardenDevice:
# Sprinkler – Override the Operate() method to print:
   "Sprinkler waters the plants evenly across the garden."
# LawnMower – Override the Operate() method to print:
   "Lawn Mower trims the grass to a uniform height."
# SoilSensor – Override the Operate() method to print:
   "Soil Sensor monitors moisture and nutrient levels."
*/

class GardenDevice
{
    public string Name{ get; set; }
    public string Brand{ get; set; }
    public int PowerUsage{ get; set; }

    public virtual void Operate()
    {
        Console.WriteLine("Each garden device operates in its own way.");
    }
}
class Sprinkler : GardenDevice
{
    public override void Operate()
    {
        Console.WriteLine("Sprinkler waters the plants evenly across the garden.");
    }
}
class LawnMower : GardenDevice
{
    public override void Operate()
    {
        Console.WriteLine("Lawn Mower trims the grass to a uniform height.");
    }
}
class SoilSensor : GardenDevice
{
    public override void Operate()
    {
        Console.WriteLine("Soil Sensor monitors moisture and nutrient levels.");
    }
}
class Program
{
    static void Main()
    {
        GardenDevice g1 = new Sprinkler();
        GardenDevice g2 = new LawnMower();
        GardenDevice g3 = new SoilSensor();

        g1.Operate();
        g2.Operate();
        g3.Operate();
        
    }
}
