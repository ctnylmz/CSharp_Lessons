using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] course = new string[]
            {
                "CSharp Camp",
                "Java Camp",
                "NodeJS Camp",
                "React Camp",
                "Pythone Camp"
            };


            /*
            for (int i = 0; i <= course.Length; i++)
            {
                Console.WriteLine(course[i]);
            }
            */

            foreach (var item in course)
            {
                Console.WriteLine(item);
            }
        }
    }
}
