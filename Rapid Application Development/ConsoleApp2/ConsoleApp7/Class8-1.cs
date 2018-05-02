using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    partial class Student
    {
        public int Mark;
        public string Name;

        public Student(int Mark, string Name)
        {

            this.Mark = Mark;

            this.Name = Name;

        }

        public Student(string Name)
        {

            this.Name = Name;
        }

    }
}
