using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <PersonModel> people = new List<PersonModel>
            {
                new PersonModel { FirstName = "Sue", LastName = "Smith", EmailAddress = "sue.smith@gmail.com" },
                new PersonModel { FirstName = "Jim", LastName = "Smith", EmailAddress = "jim.smith@gmail.com" },
                new PersonModel { FirstName = "Saradarnh", LastName = "Smith", EmailAddress = "sarah.smith@gmail.com" },
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel { Manufacturer = "Oldsmobile", Model = "Cutlas Supreme"},
                new CarModel { Manufacturer = "Nissan", Model = "Altima" },
                new CarModel { Manufacturer = "Ford", Model = "F150" },
            };
            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadWordFound += PeopleData_BadWordFound;
            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadWordFound += CarData_BadWordFound;
            peopleData.SaveToCsv(people,@"C:\Users\eerikmar\Documents\source\test\people.csv");
            carData.SaveToCsv(cars, @"C:\Users\eerikmar\Documents\source\test\cars.csv");
            Console.ReadLine();
        }

        private static void CarData_BadWordFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad word found {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadWordFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad word found {e.FirstName} {e.LastName}");
        }
    }

    public class DataAccess<T> where T : new()
    {
        public event EventHandler<T> BadWordFound;
        public void SaveToCsv(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();
            string row = string.Empty;
            bool validRow = true;

            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }

            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {
                row = string.Empty;
                foreach (var col in cols)
                {
                    row += $",{col.GetValue(item, null)}";
                }
                if (BadWordDetector(row))
                {
                    BadWordFound?.Invoke(this, item);
                    validRow = false;
                    row = "";
                    continue;
                }
                if (validRow)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
            }

            System.IO.File.WriteAllLines(filePath, rows);
        }
        public static bool BadWordDetector(string word)
        {
            bool output = false;
            List<string> badWords = new List<string> { "poop", "crap", "darn" };
            foreach (var badWord in badWords) { if (word.ToLower().Contains(badWord)) output = true; }
            return output;
        }
    }

    public static class Validators
    {
        public static bool ValidateEmail(this string email)
        {
            return email.Contains("@") && email.LastIndexOf(".") > email.LastIndexOf("@");
        }

        
    }
}
