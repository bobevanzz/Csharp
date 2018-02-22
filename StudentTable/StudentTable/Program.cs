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
            //Student[] students = db.Students.ToArray();
            Student[] students = db.Students.Where(Student => Student.GradWithHonors == true).OrderBy(student=> student.GradYear).ToArray();
            foreach (Student student in students)
            {
                string message = $"Name={student.Name}, Honor Grad={student.GradWithHonors}, Graduation year={student.GradYear}";
                Console.WriteLine(message);
            }
            Console.ReadKey();
            //foreach (Student student in students)
            //{
            //    string message = $"Name={student.Name}, Graduated with honors={student.GradWithHonors}, ";
            //    Console.WriteLine(message);
            //}
            //Console.ReadKey();
        }
    }
}
