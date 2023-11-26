using System;
using System.Collections.Generic;

// Базовий клас
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public virtual void Start()
    {
        Console.WriteLine($"The {Brand} {Model} is starting.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {Brand} {Model} is stopping.");
    }
}

// Клас автомобіля, що успадковує клас Vehicle
class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public override void Start()
    {
        Console.WriteLine($"The {NumberOfDoors}-door car {Brand} {Model} is starting.");
    }

    // Новий метод Accelerate для автомобіля
    public void Accelerate()
    {
        Console.WriteLine($"The {Brand} {Model} is accelerating.");
    }
}

// Клас велосипеда, що успадковує клас Vehicle
class Bicycle : Vehicle
{
    public bool HasBasket { get; set; }

    public override void Start()
    {
        Console.WriteLine($"The bicycle {Brand} {Model} is starting.");
    }
}

class Program
{
    static void Main()
    {
        // Створення списку транспортних засобів
        List<Vehicle> vehicles = new List<Vehicle>();

        // Введення даних вручну для автомобіля
        Console.WriteLine("Enter car information:");
        Car car = new Car();
        Console.Write("Brand: ");
        car.Brand = Console.ReadLine();
        Console.Write("Model: ");
        car.Model = Console.ReadLine();
        Console.Write("Number of doors: ");
        car.NumberOfDoors = int.Parse(Console.ReadLine());
        vehicles.Add(car);

        // Введення даних вручну для велосипеда
        Console.WriteLine("\nEnter bicycle information:");
        Bicycle bicycle = new Bicycle();
        Console.Write("Brand: ");
        bicycle.Brand = Console.ReadLine();
        Console.Write("Model: ");
        bicycle.Model = Console.ReadLine();
        Console.Write("Has basket (true/false): ");
        bicycle.HasBasket = bool.Parse(Console.ReadLine());
        vehicles.Add(bicycle);

        // Виклик методів з використанням поліморфізму
        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();

            // Перевірка, чи об'єкт є автомобілем і виклик методу Accelerate
            if (vehicle is Car)
            {
                ((Car)vehicle).Accelerate();
                Console.WriteLine("Test on car completed.");
            }

            Console.WriteLine();
        }
    }
}
