using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student zach = new Student("Zach", 254, 25, 3.21);
            Student bob = new Student("Bob", 698, 15, 3.8);
            Student larry = new Student("Larry", 88956, 2, 1.5);
            Student roy = new Student("Roy", 5, 5, 2.5);

            //Console.WriteLine("Student Information: ");

            //Console.WriteLine($"name: {zach.Name} StudentID: {zach.StudentId} Number of Credits: {zach.NumberOfCredits} GPA: {zach.Gpa}");

            List<Student> myStudents = new List<Student>(new Student[] { zach, bob });
            myStudents.Add(larry);
            myStudents.Add(roy);

            Console.WriteLine(myStudents[0].Name);
            Teacher troy = new Teacher("Troy", 5, true, 26);

            //Course pizzaNuggies = new Course("Cooking", troy, myStudents);

            Course applePizza = new Course("the light at the end of the life", troy, myStudents);

            Console.WriteLine(applePizza.Subject);
            Console.WriteLine(applePizza.Instructor.Name);
            foreach(Student student in myStudents)
            {
                Console.WriteLine(student.Name);
            }

            //Console.WriteLine($"{troy.Name} {troy.StaffId} {troy.Karate} {troy.YearsOfExp}");
        }
    }
}
