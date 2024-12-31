
while (true)
{
    //Console.Write("What is your first name? ");
    //string? firstName = Console.ReadLine();
    //Console.Write("What is your last name? ");
    //string? lastName = Console.ReadLine();

    string firstName = ValidateStringInput("What is your first name? ");
    string lastName = ValidateStringInput("What is your last name? ");

    if (firstName.ToLower() == "quit" || lastName.ToLower() == "quit")
    {
        Console.WriteLine("Buh bye!");
        break;
    }

    int age = ValidateIntInput("What is your age? ");
    DateTime birthDate = ValidateDateTimeInput("What is your birthdate? ");

    if (firstName?.ToLower() == "tim" && lastName?.ToLower() =="corey")
    {
        Console.WriteLine("Hello, Professor Corey!");
    } 
    else if (firstName?.ToLower() == "tim" || lastName?.ToLower() == "corey") 
    {
        Console.WriteLine($"Hello, {firstName} {lastName}! You have a partly great name!");
    }
    else
    {
        Console.WriteLine($"Hello, {firstName} {lastName}!");
    }

    if (age < 18)
    {
        Console.WriteLine("You are underage. Your birthday is " + birthDate.Day + "." + birthDate.Month);
    }
    else
    {
        Console.WriteLine("You are an adult.");
    }
}

int ValidateIntInput(string prompt)
{
    int result;
    bool validInput;

    do
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        validInput = int.TryParse(input, out result);

        if (!validInput)
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    } while (!validInput);

    return result;
}

DateTime ValidateDateTimeInput(string prompt)
{
    DateTime result;
    bool validInput;

    do
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        validInput = DateTime.TryParse(input, out result);

        if (!validInput)
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    } while (!validInput);

    return result;
}

string ValidateStringInput(string prompt)
{
    string? result;
    bool validInput;

    do
    {
        Console.Write(prompt);
        result = Console.ReadLine();
        validInput = !string.IsNullOrWhiteSpace(result);

        if (!validInput)
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    } while (!validInput);

    return result != null ? result : "";
}
