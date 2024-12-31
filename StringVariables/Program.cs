

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;
string filePath2 = string.Empty;

firstName = "Tim";
lastName = "Corey";
filePath = "C:\\Temp\\Demo";
filePath2 = @"C:\Temp\Demo";

Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("{0} {1}", firstName, lastName);
Console.WriteLine($"{firstName} {lastName}");

Console.WriteLine(filePath);
Console.WriteLine(filePath2);
