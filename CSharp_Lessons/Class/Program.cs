using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course0 = new Course();

            course0.CourseName = "CSharp";
            course0.CourseTeacher = "Çetin Y.";
            course0.Viewing = 301;

            Course course1 = new Course();
            course1.CourseName = "Java";
            course1.CourseTeacher = "Kerem L.";
            course1.Viewing = 134;

            Course course2 = new Course();
            course2.CourseName = "C";
            course2.CourseTeacher = "Ali K.";
            course2.Viewing = 174;


            //Console.WriteLine(course0.CourseName + " : " + course0.CourseTeacher);

            Course[] Courses = new Course[]
            {
                course0,
                course1, 
                course2
            };

            foreach (var course in Courses)
            {
                Console.WriteLine(course.CourseName);
                Console.WriteLine(course.CourseTeacher);
                Console.WriteLine(course.Viewing);
                Console.WriteLine("---------------------");
            }

        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public int Viewing { get; set; }
    }
}
