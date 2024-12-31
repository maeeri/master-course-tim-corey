using System;

namespace Homework22
{
    public static class Extensions
    {
        public static PersonModel Print(this PersonModel person)
        {
            Console.WriteLine(person);
            return person;
        }
        public static PersonModel ChangeSurname(this PersonModel person, string surname)
        {
            person.Surname = surname;
            return person;
        }
        public static EmployeeModel ChangeSurname(this EmployeeModel employee, string surname)
        {
            return (EmployeeModel)((PersonModel)employee).ChangeSurname(surname);
        }
        public static EmployeeModel GiveRaise(this EmployeeModel employee, double salary)
        {
            employee.Salary = salary;
            return employee;
        }
        public static EmployeeModel Print(this EmployeeModel employee)
        {
            Console.WriteLine(employee);
            return employee;
        }
        public static string RequestString(this string message)
        {
            string output = string.Empty;
            
            while (string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }
        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }
        public static int RequestInt(this string message, int min, int max)
        {
            return message.RequestInt(true, min, max);
        }
        private static int RequestInt(this string message, bool useMinMax = false, int min = 0, int max = 0)
        {
            int output = 0;
            bool isParsed = false;

            while (isParsed == false)
            {
                Console.Write(message);
                isParsed = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax && (output < min || output > max))
                {
                    isParsed = false;
                }
            }

            return output;
        }
        public static DateTime RequestDate(this string message)
        {
            DateTime output = DateTime.MinValue;
            bool isParsed = false;

            while (isParsed == false)
            {
                Console.Write(message);
                isParsed = DateTime.TryParse(Console.ReadLine(), out output);
            }

            return output;
        }
        public static double RequestDouble(this string message)
        {
            double output = 0;
            bool isParsed = false;
            while (isParsed == false)
            {
                Console.Write(message);
                isParsed = double.TryParse(Console.ReadLine(), out output);
            }
            return output;
        }
    }
}
