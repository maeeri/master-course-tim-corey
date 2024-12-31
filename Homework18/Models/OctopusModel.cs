using Homework18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Models
{
    public class OctopusModel : AnimalModel, ISwimmer
    {
        public double SwimSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
