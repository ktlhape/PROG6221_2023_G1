using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndCollections
{
    internal class Student
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Mark { get; set; }

        public Student(int iD, string firstname, string lastname, double mark)
        {
            ID = iD;
            Firstname = firstname;
            Lastname = lastname;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"{ID} - {Firstname} {Lastname} : {Mark}";
        }
    }
}
