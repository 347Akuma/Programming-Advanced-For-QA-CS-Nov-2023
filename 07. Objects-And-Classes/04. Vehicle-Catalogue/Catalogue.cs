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

