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

