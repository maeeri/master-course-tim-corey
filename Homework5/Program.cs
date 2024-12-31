List<string> students = new List<string>();

while (true)
{
    Console.WriteLine("Enter a student name or press enter to finish:");
    string student = Console.ReadLine();
    if (string.IsNullOrEmpty(student))
    {
        break;
    }
    students.Add(student);
}

Console.WriteLine($"You entered the name of {students.Count} students");
Console.ReadKey();