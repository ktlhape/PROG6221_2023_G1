using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            ls.Add(5); //0
            //18 - 1
            ls.Add(1); //2
            ls.Add(-4);
            ls.Add(13); // 3
            ls.Add(11); // 4
            //Console.WriteLine("Before changes");
            //foreach (int item in ls)
            //{
            //    Console.WriteLine(item);
            //}
            ls.Insert(1, 18);
            ls.Remove(-4);
            ls.RemoveAt(3);
            //Console.WriteLine("After changes\n");
            //foreach (int item in ls)
            //{
            //    Console.Write(item + " ");
            //}

            Student st1 = new Student(1, "Kabelo", "Tlhape");
            Student st2 = new Student(2, "Jason", "Smith");

            List<Student> stList = new List<Student>();
            stList.Add(st1);
            stList.Add(st2);

            foreach (Student item in stList)
            {
                Console.WriteLine(item.ID + " - " + item.Name + " " + item.Surname);
            }

         




            Console.WriteLine(IsEqual<string,int>("st",2));
            Console.Read();
        }
        static bool IsEqual<T1,T2>(T1 x, T2 y)
        {
            return x.Equals(y);
        }
    }
}
