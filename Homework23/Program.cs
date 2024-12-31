using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            List<string> list2 = new List<string> { "one", "two", "three", "four", "five" };

            PrintItem(list);
            PrintItem(list2);

            PrintItem(5);
            PrintItem("five");

            Console.ReadKey();
        }

        static void PrintItem<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
