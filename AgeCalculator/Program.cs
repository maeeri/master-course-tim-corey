while (true)
{
    Console.WriteLine("What is your age? (Type 'quit' to quit the program) ");
    string? input = Console.ReadLine();

    if (input?.ToLower() == "quit")
    {
        Console.WriteLine("\nThank you, have a nice day!");
        Console.ReadKey();
        break;
    }

    if (int.TryParse(input, out int age))
    {
        int ageEarlier = age - 25;
        string ageEarlierString = ageEarlier < 0 ? "not yet born" : ageEarlier.ToString() + " years old";
        int ageLater = age + 25;
        Console.WriteLine($"\tYou are {age} years old. \n\tIn 25 years you will be {ageLater} years old. \n\t25 years ago you were {ageEarlierString}.\n\n");
    }

    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}

