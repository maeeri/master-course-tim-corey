using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIOOP
{
    public class RequestData
    {
        public static int GetAnInt(String message)
        {
            int output = 0;
            bool isValid = false;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    isValid = int.TryParse(input, out output);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (!isValid);

            return output;
        }

        public static string GetAString(String message)
        {
            string output = "";
            bool isValid = false;

            do
            {
                Console.Write(message);
                output = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(output))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return output;
        }
        public static double GetADouble(String message)
        {
            double output = 0;
            bool isValid = false;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    isValid = double.TryParse(input, out output);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (!isValid);

            return output;
        }
    }
}
