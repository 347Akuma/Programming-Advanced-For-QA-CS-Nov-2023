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