using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMDemoLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        private string _SSN;

        public string SSN
        {
            get { return $"*******{ _SSN.Substring(_SSN.Length - 4) }"; }
            set { _SSN = value; }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, { FirstName }");
        }
    }
}   
