using Homework18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Models
{
    public class AnimalModel : IAnimal
    {
        public string Name { get; set; }
        public int NumberOfHearts { get; set; }
        public AnimalModel() { }
        public AnimalModel(string name, int numberOfHearts)
        {
            this.Name = name;
            this.NumberOfHearts = numberOfHearts;
        }
        public void Eat()
        {
            Console.WriteLine("Yum yum!");
        }

        public void Sleep()
        {
            Console.WriteLine("ZZZzzzZZZzzz");
        }

        public void Move()
        {
            Console.WriteLine($"{this.Name} moved!");
        }
    }
}
