
string firstNamesData = "John,Jane,Joe,Jill,Jack";
List<string> firstNames = firstNamesData.Split(',').ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName.Trim());
}

