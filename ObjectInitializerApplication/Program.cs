using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerApplication
{

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };
            Student std1 = new Student()
            {
                StudentID = 2,
                StudentName = "Ram",
                Age = 22,
                Address = "Chicaho"
            };
            Console.WriteLine("Student ID: {0}", std.StudentID);
            Console.WriteLine("Student ID: {0}", std1.StudentID);
            Console.ReadLine();

        }
    }
}
