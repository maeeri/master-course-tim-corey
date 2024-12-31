using System;

namespace Homework22
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                if (_age == 0)
                {
                    _age = (DateTime.Now - BirthDate).Days / 365;
                }

                return _age;
            }
        }

        public PersonModel()
        {
        }
        public PersonModel(string name, string surname, DateTime dob)
        {
            Name = name;
            Surname = surname;
            BirthDate = dob;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}
