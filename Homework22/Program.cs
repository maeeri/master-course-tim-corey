using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.Name = "What is your first name? ".RequestString();
            employee.Surname = "What is your last name? ".RequestString();
            employee.BirthDate = "What is your date of birth? (dd/mm/yyyy) ".RequestDate();
            employee.Salary = "What is your salary? ".RequestDouble();
            employee.Print();

            string newSurname = "What is your new surname? ".RequestString();
            double newSalary = "What is your new salary? ".RequestDouble();
            employee.GiveRaise(newSalary).ChangeSurname(newSurname).Print();

            Console.ReadLine();
        }
    }
}
