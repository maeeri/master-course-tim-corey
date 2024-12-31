//using FrameworkLibrary;

using CoreLibrary;

namespace ClassLibraryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new();
            string message = generators.WelcomeMessage("Mr.", "Corey");
            Console.WriteLine(message);
            PersonModel person = new()
            {
                Prefix = "Mr.",
                FirstName = "Corey",
                LastName = "Hudson"
            };
            message = generators.FarewellMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
