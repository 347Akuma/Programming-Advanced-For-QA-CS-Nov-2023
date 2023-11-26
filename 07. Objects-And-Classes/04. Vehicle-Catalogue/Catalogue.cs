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

    public Catalogue(List<Truck> trucks, List<Car> cars)
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();       
    }
}

