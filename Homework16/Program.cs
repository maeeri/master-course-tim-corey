public static class Program
{
    static void Main(string[] args)
    {
        var car = new Car();
        car.NumberOfPassengers = 4;
        car.NumberOfDoors = 4;

        var boat = new Boat();
        boat.NumberOfPassengers = 6;
        boat.Name = "S.S. Minnow";

        var motorcycle = new Motorcycle();
        motorcycle.NumberOfPassengers = 2;

        Console.WriteLine($"Car: {car.NumberOfPassengers} passengers, {car.NumberOfDoors} doors");
        Console.WriteLine($"Boat: {boat.NumberOfPassengers} passengers, {boat.Name}");
        Console.WriteLine($"Motorcycle: {motorcycle.NumberOfPassengers} passengers");
    }
}
public class Vehicle
{
    public int NumberOfPassengers { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

public class Boat : Vehicle
{
    public string Name { get; set; }
}

public class  Motorcycle : Vehicle
{
    
}
