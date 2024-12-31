using System;

namespace Homework22
{
    public class EmployeeModel : PersonModel
    {
        public double Salary { get; set; }

        public EmployeeModel()
        {
        }
        public EmployeeModel(string name, string surname, DateTime dob, double salary) : base(name, surname, dob)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: {Salary}";
        }
    }
}
