using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        int NumberOfHearts { get; set; }
        void Eat();
        void Sleep();
    }
}
