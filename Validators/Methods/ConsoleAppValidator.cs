using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLibrary.Methods
{
    public static class ConsoleAppValidator
    {
        public static string ValidateString(string message)
        {
            string output = "";
            do
            {
                Console.Write(message);
                output = Console.ReadLine();
            } while (string.IsNullOrEmpty(output));
            return output;
        }
    }
}
