
while (true)
{
    try
    {
        Console.WriteLine("What is your age? ");
        string ageText = Console.ReadLine();

        bool isValidInt = int.TryParse(ageText, out int age);

        if (!isValidInt)
        {
            throw new FormatException();
        }

        if (age < 0 || age > 120)
        {
            throw new OverflowException();
        }

        Console.WriteLine($"This is valid: {isValidInt}. Your age is {age}");
    }
    catch (FormatException)
    {
        Console.WriteLine("The age you entered is not a valid number.");
        break;
    }
    catch (OverflowException)
    {
        Console.WriteLine("The age you entered is too large or too small.");
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("An unexpected error occurred.");
        break;
    }
}


