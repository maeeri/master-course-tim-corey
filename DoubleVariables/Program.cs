using System.Collections;

double averageAge;
ArrayList ages = new ArrayList();

while (true)
{
    Console.WriteLine("Enter an age or type 'done' to finish");
    string input = Console.ReadLine();
    if (input == "done")
    {
        break;
    }
    ages.Add(double.Parse(input));
}
double calculateAverageAge()
{
    double sum = 0;
    foreach (double age in ages)
    {
        sum += age;
    }
    return sum / ages.Count;
}
averageAge = calculateAverageAge();

Console.WriteLine(averageAge);