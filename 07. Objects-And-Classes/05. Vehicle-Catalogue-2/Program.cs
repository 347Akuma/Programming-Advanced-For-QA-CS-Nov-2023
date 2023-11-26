//using System.Diagnostics;

Catalogue catalogue = new Catalogue();

string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] data = input.Split("/");

    string type = data[0];
    string brand = data[1];
    string model = data[2];

    if (type == "Car")
    {
        string horsepower = data[3];
        Car currentCar = new Car(brand, model, horsepower);
        catalogue.Cars.Add(currentCar);

    }
    else if (type == "Truck")
    {
        string weight = data[3];
        Truck currentTruck = new Truck(brand, model, weight);
        catalogue.Trucks.Add(currentTruck);
    }
}

catalogue.PrintCatalogueOfCars(catalogue.Cars);
catalogue.PrintCatalogueOfTrucks(catalogue.Trucks);

internal class Car
{
    string brand;
    string model;
    string horsepower;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string HorsePower
    {
        get { return horsepower; }
        set { horsepower = value; }
    }

    public Car(string brand, string model, string horsepower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsepower;
    }
}

internal class Truck
{
    string brand;
    string model;
    string weight;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public Truck(string brand, string model, string weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}

internal class Catalogue
{
    List<Truck> trucks;
    List<Car> cars;

    public List<Truck> Trucks
    {
        get { return trucks; }
        set { trucks = value; }
    }
    public List<Car> Cars
    {
        get { return cars; }
        set { cars = value; }
    }

    public Catalogue()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public void PrintCatalogueOfTrucks(List<Truck> trucks)
    {
        trucks = trucks.OrderBy(t => t.Brand).ToList();
        Console.WriteLine("Trucks:");
        foreach (Truck truck in trucks)
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }

    public void PrintCatalogueOfCars(List<Car> cars)
    {
        cars = cars.OrderBy(c => c.Brand).ToList();
        Console.WriteLine("Cars:");
        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }
    }
}


