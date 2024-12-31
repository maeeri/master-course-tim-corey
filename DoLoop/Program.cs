
Console.Write("What is your age? ");
int age = ValidateAgeInput(Console.ReadLine());
int i = 1;

Console.Write("How many guests are in the party? ");
int numberOfGuests = ValidateIntInput(Console.ReadLine());

List<string> guests = new List<string>();

while (i <= numberOfGuests)
{
    Console.Write("Enter the name of guest " + i + ": ");
    guests.Add(Console.ReadLine());
    i++;
}

Console.WriteLine("The party has " + numberOfGuests + " guests.");
Console.WriteLine("The guests are: ");
foreach (string guest in guests)
{
    Console.WriteLine(guest);
}
int ValidateAgeInput(string input)
{
    int age;
    while (!int.TryParse(input, out age) || age < 0 || age > 120)
    {
        Console.WriteLine("Invalid input. Please enter a valid age.");
        input = Console.ReadLine();
    }
    return age;
}

int ValidateIntInput(string input)
{
    int number;
    while (!int.TryParse(input, out number))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        input = Console.ReadLine();
    }
    return number;
}

string ValidateStringInput(string input)
{
    while (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid input. Please enter a valid string.");
        input = Console.ReadLine();
    }
    return input;
}
