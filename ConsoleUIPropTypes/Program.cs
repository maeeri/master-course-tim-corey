
using ConsoleUIPropTypes;

PersonModel person = new PersonModel();
person.FirstName = "Tim";
person.Age = 35;
person.SSN = "250201A5655";

Console.WriteLine(person.FullName);

Console.WriteLine(person.SSN);

Console.ReadKey();
