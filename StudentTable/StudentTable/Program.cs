using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentTable
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();
            //Student[] students = db.Students.ToArray(); //Task 1
            //foreach (Student student in students)
            //{
            //    string message = $"Id={student.Id}";
            //    Console.WriteLine(message);
            //}
            //Console.ReadKey();

            //Student[] students = db.Students.ToArray();
            //foreach (Student student in students) // Task 2
            //{
            //    string message = $"Name={student.Name}, ";
            //    Console.WriteLine(message);
            //}
            //Console.ReadKey();

            //Student[] students = db.Students.Where(Student => Student.GradWithHonors == true) //Task 3
            //                                .OrderBy(student => student.GradYear).ToArray();
            //foreach (Student student in students)
            //{
            //    string message = $"Name={student.Name}, Honor Grad={student.GradWithHonors}, Graduation year={student.GradYear}";
            //    Console.WriteLine(message);
            //}
            //Console.ReadKey();

        }
    }
}
