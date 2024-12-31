using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
                Console.Write("What is your name: ");
                name = Console.ReadLine();
                ComplexMethod(name);
                //AnotherMethod();
                SimpleMethod();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid Cast Exception");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("You forgot to finsish your code!!!!");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling these methods!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument Exception");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex.Message.Contains("Justin"))
            {
                Console.WriteLine("Justin is not allowed in this method");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (name.ToLower() == "brenda")
            {
                Console.WriteLine("Branda is not allowed in this method");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This is the finally block");
            }
            Console.ReadKey();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "justin")
            {
                throw new ArgumentException("Justin is not allowed in this method");
            }
            Console.WriteLine($"Hello, {name}");
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod");
        }

        private static void AnotherMethod()
        {
            throw new NotImplementedException();
        }
    }
}
