using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

public class Human : Vehicle
{
    public Human(int speed)
    {
        Speed = speed;
        Capacity = 1;
    }

    public override void Move()
    {
        Console.WriteLine($"Walking with speed {Speed} km/h");
    }
}

public class Car : Vehicle
{
    public Car(int speed, int capacity)
    {
        Speed = speed;
        Capacity = capacity;
    }

    public override void Move()
    {
        Console.WriteLine($"Driving a car with speed {Speed} km/h");
    }
}

public class Bus : Vehicle
{
    public Bus(int speed, int capacity)
    {
        Speed = speed;
        Capacity = capacity;
    }

    public override void Move()
    {
        Console.WriteLine($"Taking a bus with speed {Speed} km/h");
    }
}

public class Train : Vehicle
{
    public Train(int speed, int capacity)
    {
        Speed = speed;
        Capacity = capacity;
    }

    public override void Move()
    {
        Console.WriteLine($"Riding a train with speed {Speed} km/h");
    }
}

public class Route
{
    public string? Start { get; set; }
    public string? End { get; set; }
}

public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public IEnumerable<Vehicle>? Vehicles { get; internal set; }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void CalculateOptimalRoute(Route route, Type vehicleType)
    {
        // Logic to calculate the optimal route based on the vehicle type
        Console.WriteLine($"Calculating optimal route for {vehicleType.Name} from {route.Start} to {route.End}");
    }

    public void EmbarkPassengers(Vehicle vehicle, int passengers)
    {
        // Logic to embark passengers onto the vehicle
        Console.WriteLine($"Embarking {passengers} passengers onto the {vehicle.GetType().Name}");
    }

    public void DisembarkPassengers(Vehicle vehicle, int passengers)
    {
        // Logic to disembark passengers from the vehicle
        Console.WriteLine($"Disembarking {passengers} passengers from the {vehicle.GetType().Name}");
    }
}

class Program
{
    static void Main()
    {
        Human human = new Human(speed: 5);
        Car car = new Car(speed: 60, capacity: 4);
        Bus bus = new Bus(speed: 40, capacity: 20);
        Train train = new Train(speed: 100, capacity: 100);

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        Route route = new Route { Start = "City A", End = "City B" };

        foreach (Vehicle vehicle in network.Vehicles)
        {
            vehicle.Move();
        }

        // Use additional methods in TransportNetwork, Route, and Vehicle classes as needed.
    }
}
