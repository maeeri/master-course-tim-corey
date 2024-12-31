
Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup.Add("a", "apple");
lookup.Add("b", "banana");
lookup.Add("c", "cherry");

Console.WriteLine($"a: {lookup["a"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(1, "Scott");
employees.Add(76, "Bill");

Console.WriteLine(employees[76]);

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek.Add("Monday", 1);
dayOfWeek.Add("Tuesday", 2);
dayOfWeek.Add("Wednesday", 3);
dayOfWeek.Add("Thursday", 4);
dayOfWeek.Add("Friday", 5);
dayOfWeek.Add("Saturday", 6);
dayOfWeek.Add("Sunday", 7);

foreach (var day in dayOfWeek)
{
    Console.WriteLine($"{day.Key}: {day.Value}");
}