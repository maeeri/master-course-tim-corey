

while (true)
{
   string firstName = ValidateStringInput("Enter your first name: ");

    if (firstName.ToLower() == "exit")
    {
        break;
    }

    if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
    {
        Console.WriteLine("Hello, Professor Corey!");
    }
    else
    {
        Console.WriteLine($"Hello, Student!");
    }
}

string ValidateStringInput(string prompt)
{
    string input;
    bool valid = false;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine();

        if (input.Length > 0)
        {
            valid = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    } while (!valid);
    return input;
}