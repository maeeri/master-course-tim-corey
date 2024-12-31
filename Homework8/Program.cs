
List<string> names = new();

while (true)
{
    Console.WriteLine("Enter a name:");
    string name = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(name))
    {
        break;
    }
    names.Add(name);
}

foreach (var name in names)
{
    Console.WriteLine($"Hello {name}");
}
