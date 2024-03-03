using System;


interface ICar
{
    // Properties
    string Brand { get; }
    string Model { get; }

    // Method
    string Describe();
}


class Car : ICar
{
   
    public string Brand { get; }
    public string Model { get; }

    
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    // Interface method
    public string Describe()
    {
        return $"Car - Brand: {Brand}, Model: {Model}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to input information for a car
        Console.WriteLine("Enter Car's Brand:");
        string carBrand = Console.ReadLine();

        Console.WriteLine("Enter Car's Model:");
        string carModel = Console.ReadLine();

        // Create a car object with user-provided information
        Car car = new Car(carBrand, carModel);

        // Display information
        Console.WriteLine(car.Describe());
    }
}
