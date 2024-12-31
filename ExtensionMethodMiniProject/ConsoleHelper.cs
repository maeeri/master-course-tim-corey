using System;

namespace ExtensionMethodMiniProject
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = string.Empty;
            while (string.IsNullOrEmpty(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }

            return output;
            
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int min, int max)
        {
            return message.RequestInt(true, min, max);
        }

        private static int RequestInt(this string message, bool useMinMax, int min = 0, int max = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInValidRange = min <= output && output <= max;
                }
            }

            return output;
        }
    }
}
