using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class Methods
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to this party guest book");
            Console.WriteLine("********************************");
        }
        internal static (string name, int numberOfGuests) GetGuestInfo()
        {
            Console.WriteLine("Enter your party name:");
            string? name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Enter the number of guests:");
            int numberOfGuests;
            bool validInput = int.TryParse(Console.ReadLine(), out numberOfGuests);

            while (!validInput || numberOfGuests < 0)
            {
                Console.WriteLine("Please enter a valid number of guests:");
                validInput = int.TryParse(Console.ReadLine(), out numberOfGuests);
            }

            return (name, numberOfGuests);
        }

        internal static void PrintGuests(List<(string name, int numberOfGuests)> guests)
        {
            int totalGuests = 0;
            Console.WriteLine("Guests:");
            foreach (var guest in guests)
            {
                Console.WriteLine($"{guest.name}");
                totalGuests += guest.numberOfGuests;
            }

            Console.WriteLine($"There are {totalGuests} guests at the party");
        }

        public static void ManageGuests()
        {
            WelcomeUser();
            List<(string name, int numberOfGuests)> guests = new List<(string name, int numberOfGuests)>();
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Enter 1 to add a guest or 2 to exit:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        guests.Add(GetGuestInfo());
                        break;
                    case "2":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }

            PrintGuests(guests);
        }
    }
}
