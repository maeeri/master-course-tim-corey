using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel math101 = new CollegeClassModel("Math 101", 3);
            math101.ClassFull += CollegeClass_ClassFull;

            math101.SignUpStudent("John Doe").PrintToConsole();
            math101.SignUpStudent("Jane Doe").PrintToConsole();
            math101.SignUpStudent("Jim Doe").PrintToConsole();
            math101.SignUpStudent("Jill Doe").PrintToConsole();

            CollegeClassModel history101 = new CollegeClassModel("History 101", 2);
            history101.ClassFull += CollegeClass_ClassFull;
            history101.SignUpStudent("John Doe").PrintToConsole();
            history101.SignUpStudent("Jane Doe").PrintToConsole();
            history101.SignUpStudent("Jim Doe").PrintToConsole();
            history101.SignUpStudent("Jill Doe").PrintToConsole();

            Console.ReadLine();
        }
        private static void CollegeClass_ClassFull(object sender, string e)
        {
            CollegeClassModel model =  (CollegeClassModel)sender;
            Console.WriteLine($"{model.CourseTitle}: Full");
            Console.WriteLine();
        }
    }
    
    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {
        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public event EventHandler<string> ClassFull;


        public string CourseTitle { get; private set; }
        public int MaxStudents { get; private set; }

        public CollegeClassModel(string courseTitle, int maxStudents)
        {
            CourseTitle = courseTitle;
            MaxStudents = maxStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = string.Empty;

            if (enrolledStudents.Count < MaxStudents)
            {
                enrolledStudents.Add(studentName);
                output = string.Format("{0} was successfully enrolled in {1}", studentName, CourseTitle);

                if (enrolledStudents.Count == MaxStudents)
                {
                    ClassFull?.Invoke(this, $"{CourseTitle} is full");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = string.Format("{0} was added to the waiting list for {1}", studentName, CourseTitle);
            }

            return output;
        }

    }
}
