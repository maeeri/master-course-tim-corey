using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemoLibrary
{
    public class BuiltStrings
    {
        public string Build(char[] chars, char separator)
        {
            return string.Join(separator.ToString(), chars);
        }
    }
}
