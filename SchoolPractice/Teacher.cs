using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string Name { get; set; }
        public int StaffId { get; set; }
        public bool Karate { get; set; }
        public int YearsOfExp { get; set; }

        public Teacher(string name, int staffId, bool karate, int yearsOfExp)
        {
            Name = name;
            StaffId = staffId;
            Karate = karate;
            YearsOfExp = yearsOfExp;
        }

        public Teacher(string name): this(name, 0, false, 0) { }
    }
}
