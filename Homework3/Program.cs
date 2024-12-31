
using System;

while (true)
{
    string firstName = ValidateStringInput("Enter your name: ");
    int age = ValidateAgeInput("Enter your age: ");

    if (firstName == "quit" || age == -1)
    {
        break;
    }

    string formattedName = firstName.ToLower() == "bob" || firstName.ToLower() == "sue" ? $"Professor {firstName}" : firstName;
    Console.WriteLine(age >= 21 ? $"Welcome to class, {formattedName}" : $"You ought to wait {21 - age} years to take this class, {formattedName}");
}

string ValidateStringInput(string prompt)
{
    string input;
    bool valid = false;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine();
        if (input.Trim().Length > 0)
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

int ValidateAgeInput(string prompt)
{
    int input;
    bool valid = false;
    do
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out input) && input >= 0)
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
