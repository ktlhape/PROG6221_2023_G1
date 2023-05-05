using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int iD, string name, string surname)
        {
            ID = iD;
            Name = name;
            Surname = surname;
        }
    }
}
