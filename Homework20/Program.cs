using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeModel("John", "Manager", 1000);
            Console.ReadLine();
        }

        public class EmployeeModel
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public int Salary { get; set; }

            public EmployeeModel(string name, string position, int salary)
            {
                Name = name;
                Position = position;
                Salary = salary;
            }

            public EmployeeModel()
            {
            }

            public EmployeeModel(string name)
            {
                Name = name;
            }
        }
    }
}
