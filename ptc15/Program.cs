/*
    1.	Method Overloading
	    •	Create a DisplayInfo() method in the Vehicle class.
	    •	Overload it so it can:
	    •	Display basic info (name, speed, type)
	    •	Display info with an extra note (like “urgent” or “maintenance”)
	2.	Properties
	    •	Each Vehicle should have properties:
	    •	Name (string)
	    •	Speed (int)
	    •	Type (enum VehicleType)
	3.	Constructors
	    •	Default constructor sets default values.
	    •	Parameterized constructor sets all fields.
	    •	Copy constructor copies data from another vehicle object.
	4.	Enumeration
	    •	Define an enum VehicleType with values: Car, Bike, Truck.
	5.	Inheritance
	    •	Create derived classes from Vehicle:
	    •	Car → extra property: Doors
	    •	Bike → extra property: HasCarrier
	    •	Truck → extra property: LoadCapacity
	6.	Polymorphism
	    •	Compile-time polymorphism: Overload Start() in Car to optionally use a turbo boost.
	    •	Run-time polymorphism: Override Start() in all derived classes to show specific messages when starting the vehicle.
	7.	Main Program
	    •	Create multiple vehicles (using default, parameterized, and copy constructor).
	    •	Store them in an array of Vehicle.
	    •	Loop through the array and:
	    •	Call DisplayInfo()
	    •	Call Start()
	    •	Demonstrate method overloading by calling DisplayInfo() with an extra note on some objects.

*/
