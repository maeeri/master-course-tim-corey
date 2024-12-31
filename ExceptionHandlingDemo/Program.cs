using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 1, 3, 5 };
            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                //catch (IndexOutOfRangeException ex)
                //{
                //    Console.WriteLine("Index out of range exception occurred");
                //    Console.WriteLine(ex.Message);
                //    break;
                //}
                catch (Exception ex)
                {
                    Console.WriteLine("An exception occurred ");
                    //Console.WriteLine(ex.Message);
                    throw;
                }
            }
            Console.ReadKey();
        }
    }
}
