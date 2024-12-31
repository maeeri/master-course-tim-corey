namespace AMDemoLibrary
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }

        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }
}
