using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIPropTypes
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }
        private string _ssn;

        public string SSN
        {
            get 
            { 
                string output = "******_" + _ssn.Substring(_ssn.Length - 4);
                return output; 
            }
            set { _ssn = value; }
        }


        private int _age;

        public int Age
        {
            get 
            { 
                return _age; 
            }
            set 
            {
                if (value >= 0 && value <= 126) 
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be between 0 and 126.", "value");
                }
                
            }
        }

        private string _password;

        public string Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; 
            }
        }

        public PersonModel()
        {

        }
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

    }
}