
Dictionary<string, string> employees = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("\nEnter employee name (or press enter to move on): ");
    string name = Console.ReadLine();
    if (string.IsNullOrEmpty(name))
    {
        break;
    }
    Console.WriteLine("Enter employee id: ");
    string id = Console.ReadLine();
    employees.Add(id, name);
}

bool continueAsking;

do
{
    continueAsking = ValidateIdInput(employees);

} while (continueAsking);

Console.WriteLine("");

bool ValidateIdInput(Dictionary<string, string> dict)
{
    while (true)
    {
        Console.WriteLine("\nEnter employee id to look up (or press enter to finish): ");
        string id = Console.ReadLine();
        if (string.IsNullOrEmpty(id))
        {
            Console.WriteLine("Thank you and goodbye");
            return false;
        }
        else if (dict.ContainsKey(id))
        {
            Console.WriteLine(dict[id]);
            break;
        }
        else
        {
            Console.WriteLine("Employee not found. Try again.");
        }
    }
    return true;
}