using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student caillou = new Student("Caillou");
            Console.WriteLine(caillou.GetGradeLevel(35));
            Console.WriteLine(caillou.Gpa);
            caillou.AddGrade(3, 4.0);
            caillou.AddGrade(4, 3.5);
            caillou.AddGrade(4, 3.0);
            caillou.AddGrade(40, 4.0);
            Console.WriteLine(caillou.Gpa);
            Console.WriteLine(caillou.ToString());
            Student appleDog = new Student("Apple Dog");
            Student dora = new Student("Dora");
            Console.WriteLine(Environment.NewLine + appleDog.ToString());
            Console.WriteLine(Environment.NewLine + dora.ToString());
            // TODO: Test your exercise solutions with print statements here.
        }
    }
}