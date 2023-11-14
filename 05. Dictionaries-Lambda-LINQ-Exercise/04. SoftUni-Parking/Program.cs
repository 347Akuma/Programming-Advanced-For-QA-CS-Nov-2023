int n = int.Parse(Console.ReadLine());

Dictionary<string, string> parkingDataBase = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(" ");

    if (command[0] == "register")
    {
        string username = command[1];
        string licensePlate = command[2];

        if (parkingDataBase.ContainsKey(username) && parkingDataBase[username] == licensePlate)
        {
            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
        }
        else
        {
            parkingDataBase.Add(username, licensePlate);
            Console.WriteLine($"{username} registered {licensePlate} successfully");
        }
    }
    else
    {
        string username = command[1];

        if (!parkingDataBase.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parkingDataBase.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}
foreach (KeyValuePair<string, string> pair in parkingDataBase)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}