using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string lastName)
        {
            return $"Welcome {prefix} {lastName}";
        }

        public string FarewellMessage(string firstName, string lastName)
        {
            return $"I hope you enjoyed your time with us {firstName} {lastName}. Please come back soon.";
        }
    }
}
