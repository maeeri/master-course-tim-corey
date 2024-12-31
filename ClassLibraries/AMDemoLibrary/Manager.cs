using System;

namespace AMDemoLibrary
{
    public class Manager : Employee
    {
        public void GetAllNmaes()
        {
            Console.WriteLine($"{FirstName} {LastName} {formerLastName}");
        }
    }
}
