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