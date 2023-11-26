namespace _03._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Box> boxes = new List<Box>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int quantity = int.Parse(data[2]);
                decimal price = decimal.Parse(data[3]);

                Item currentItem = new Item(itemName, price);
                Box currrentBox = new Box(serialNumber, currentItem, quantity);

                boxes.Add(currrentBox);
            }

            var orderedBoxes = boxes.OrderByDescending(b => b.PriceForABox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - {box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- {box.PriceForABox:f2}");
            }
        }
    }
}




public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}



public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForABox { get; set; }

    public Box(string serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;

        PriceForABox = item.Price * itemQuantity;
    }
}
