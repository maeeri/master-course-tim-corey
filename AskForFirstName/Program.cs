
while (true)
{
    Console.WriteLine("~~~~Welcome to this Greeting App~~~~");
    Console.WriteLine("------------------------------------");
    Console.Write("Please give your first name: ");

    string? firstName;
    firstName = Console.ReadLine();

    Console.WriteLine("Hello, " + firstName);

    Console.Write("Do you want to quit? ");
    string? answer;
    answer = Console.ReadLine();

    if (answer?.ToLower() == "y" || answer?.ToLower() == "yes")
    {
        break;
    }
}

