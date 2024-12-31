using System;

namespace Homework24
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public EventHandler<Person> PersonCreated;
        public Person()
        {

        }

        public Person(string name, string surname, int age, EventHandler<Person> handler)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PersonCreated += handler;
            PersonCreated?.Invoke(this, this);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}
