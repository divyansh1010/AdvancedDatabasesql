using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    partial class Student
    {
        public int Age;
        public string Course;

        public Student() { }

        public Student(string Course, int Age)
        {

            this.Course = Course;

            this.Age = Age;
        }

    }
}