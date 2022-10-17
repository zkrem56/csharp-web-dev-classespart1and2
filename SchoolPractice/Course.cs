using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Subject { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> Students { get; set; }

        public Course(string subject, Teacher instructor, List<Student> students)
        {
            Subject = subject;
            Instructor = instructor;
            Students = students;
        }
    }
}
