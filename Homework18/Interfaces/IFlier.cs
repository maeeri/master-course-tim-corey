using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Interfaces
{
    public interface IFlier: IAnimal
    {
        double AirSpeed { get; set; }
    }
}
