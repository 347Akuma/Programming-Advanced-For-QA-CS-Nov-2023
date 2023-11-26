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
    }
    else if (type == "Truck")
    {
        string weight = data[3];
    }


}