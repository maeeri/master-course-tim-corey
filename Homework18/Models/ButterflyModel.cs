using Homework18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Models
{
    internal class ButterflyModel : AnimalModel, IFlier
    {
        public ButterflyModel(string name, double airSpeed)
        {
            AirSpeed = airSpeed;
            NumberOfHearts = 1;
            Name = name;
        }

        public double AirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
