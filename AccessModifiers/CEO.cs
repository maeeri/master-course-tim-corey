using System;
using AMDemoLibrary;

namespace AccessModifiers
{
    public class CEO : Manager
    {
        public void GetEmployeeInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUsecureConnectionInfo();
            Console.WriteLine($"{FirstName} {LastName} {EmployeeCode}");
        }
    }
}
