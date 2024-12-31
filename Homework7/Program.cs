
Console.WriteLine("Please provide a comma-separated list of names. Do not put any spaces around the commas.");
string names = Console.ReadLine();

string[] namesArray = names.Split(',');

for (int i = 0; i < namesArray.Length; i++)
{
    Console.WriteLine($"Hello {namesArray[i]}");
}
