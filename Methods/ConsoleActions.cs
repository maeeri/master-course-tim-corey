using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

internal static class ConsoleActions
{
    public static string AskFirstName()
    {
        Console.WriteLine("What is your first name?");
        string firstName = ValidateStringInput(Console.ReadLine());
        return firstName;
    }

    public static string AskLastName()
    {
        Console.WriteLine("What is your last name?");
        string lastName = ValidateStringInput(Console.ReadLine());
        return lastName;
    }

    public static (string firstName, string lastName) GetFullName()
    {
        string firstName = AskFirstName();
        string lastName = AskLastName();
        return (firstName, lastName);
    }

    public static void SayHi(string firstName)
    {
        Console.WriteLine($"Hi there, {firstName}!");
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }

    public static int ValidateIntInput(string input)
    {
        int result;
        while (!int.TryParse(input, out result))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            input = Console.ReadLine();
        }

        return result;
    }

    public static DateTime ValidateDateTimeInput(string input)
    {
        DateTime result;
        while (!DateTime.TryParse(input, out result))
        {
            Console.WriteLine("Invalid input. Please enter a valid date and time.");
            input = Console.ReadLine();
        }

        return result;
    }

    public static string ValidateStringInput(string input)
    {
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Please enter a valid string.");
            input = Console.ReadLine();
        }

        return input;
    }

    public static bool ValidateYesOrNoInput(string input)
    {
        while (input.ToLower() != "yes" && input.ToLower() != "no")
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            input = Console.ReadLine();
        }

        return input.ToLower() == "yes";
    }
}


