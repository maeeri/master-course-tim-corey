

string[] names = ["Sarah", "Marie", "Tim"];
int index;

index = ValidateIndexInput("Enter a number between 1 and 3: ") - 1;

Console.WriteLine($"The name at position {index+1} is {names[index]}");
int ValidateIndexInput(string prompt)
{
    int input;
    bool valid = false;
    do
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 3)
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