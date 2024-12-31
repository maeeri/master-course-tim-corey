using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMDemoLibrary;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();
            person.SavePerson();
            Console.ReadLine();
        }
    }
}
