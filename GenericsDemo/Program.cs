using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>();
            //List<string> stringList = new List<string>();

            //objectList.Add(1);
            //objectList.Add("Hello");

            //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //string result = FizzBuzz("tests");
            //Console.WriteLine($"Tests: {result}");

            //result = FizzBuzz(15);
            //Console.WriteLine($"15: {result}");

            //result = FizzBuzz(true);
            //Console.WriteLine($"true: {result}");

            PersonModel person = new PersonModel { FirstName = "Jane", LastName = "Smith", HasError = true };
            PersonModel person2 = new PersonModel { FirstName = "John", LastName = "Doe", HasError = false };
            //result = FizzBuzz(person);
            //Console.WriteLine($"Person: {result}");

            GenericHelper<PersonModel, CarModel> peopleHelper = new GenericHelper<PersonModel, CarModel>();
            peopleHelper.CheckItemAndAdd(person);

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected");
            }

            Console.ReadLine();
        }

        private static string FizzBuzz<T>(T item)
        {
            string output = string.Empty;

            int itemLength = item.ToString().Length;

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }
            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }
            return output;
        }
    }

    public class GenericHelper<T, U> where T : IErrorCheck where U : class
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();
        public void CheckItemAndAdd(T item)
        {
            if (item.HasError == false)
            {
                Items.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }
        }
        public T GetDefault()
        {
            return default(T);
        }
    }

    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }

    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactured { get; set; }
        public bool HasError { get; set; }
    }

    public class  PersonModel :  IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get; set; }
    }
}
