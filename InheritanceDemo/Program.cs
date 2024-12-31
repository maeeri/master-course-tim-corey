using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new SmartPhone();
            phone.PlaceCall("555-555-5555");
            phone.EndCall("555-555-5555", "Call ended");
            
            Console.ReadLine();
        }
    }
}
