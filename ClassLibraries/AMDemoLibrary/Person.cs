using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDemoLibrary
{
    public class Person
    {
        private protected string formerLastName = "";
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private string _SSN;

        public string SSN
        {
            get { return $"*******{_SSN.Substring(_SSN.Length - 4)}"; }
            set { _SSN = value; }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, {FirstName}");
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SavePerson()
        {
            string conn = new DataAccess().GetConnectionString();
            Console.WriteLine("Saving Person");
        }
    }
}
