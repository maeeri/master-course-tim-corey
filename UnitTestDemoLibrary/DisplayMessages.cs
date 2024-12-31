namespace UnitTestDemoLibrary
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = string.Empty;

            if (hourOfTheDay < 12)
            {
                output = $"Good Morning {firstName}";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good Afternoon {firstName}";
            }
            else
            {
                output = $"Good Evening {firstName}";
            }   

            return output;
        }

    }
}
