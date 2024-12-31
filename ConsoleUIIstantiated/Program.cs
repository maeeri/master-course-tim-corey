

using ConsoleUIIstantiated;

PersonModel person = new PersonModel("Mae", "Me", "email@email.com");
Lazy<PersonModel> lazyPerson = new Lazy<PersonModel>(() => new PersonModel("Thing","One"));

ProcessPerson.GreetPerson(lazyPerson.Value);

Console.WriteLine(person.HasBeenGreeted + " " + lazyPerson.Value.HasBeenGreeted);

Console.ReadKey();

