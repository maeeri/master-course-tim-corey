using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;
using ValidationLibrary.Methods;

namespace BetterGuestBookApp.Methods
{
    public static class ConsoleActions
    {
        public static void AddGuest(List<GuestModel> guests)
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                guest.FirstName = GetStringInput("What is your first name?");
                guest.LastName = GetStringInput("What is your last name?");
                guest.MessageToHost = GetStringInput("What would you like to say to your host?");
                guests.Add(guest);
                moreGuestsComing = GetStringInput("Do you want to add another guest? (yes/no)");

            } while (moreGuestsComing.Equals("yes", StringComparison.OrdinalIgnoreCase));
        }

        public static string GetStringInput(string message)
        {
            string output = "";
            do
            {
                Console.Write(message);
                output = Console.ReadLine();
            } while (string.IsNullOrEmpty(output));
            return output;
        }

        public static void DisplayGuests(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
       
    }
}
