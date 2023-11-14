Dictionary<string, List<string>> companyDataBase = new Dictionary<string, List<string>>();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputSplit = input.Split(" -> ").ToArray();

    string companyName = inputSplit[0];
    string employeeID = inputSplit[1];

    if (companyDataBase.ContainsKey(companyName))
    {
        if (companyDataBase[companyName].Contains(employeeID))
        {
            continue;
        }
        else
        {
            companyDataBase[companyName].Add(employeeID);
        }
    }
    else
    {
        companyDataBase.Add(companyName, new List<string>() { employeeID });
    }
}

foreach (KeyValuePair<string, List<string>> companyEmployee in companyDataBase)
{
    Console.WriteLine($"{companyEmployee.Key}");

    foreach (string employeeBadge in companyEmployee.Value)
    {
        Console.WriteLine($"-- {employeeBadge}");
    }
}