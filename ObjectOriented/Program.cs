using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.StudentNum = Console.ReadLine();//set the studentNum
            Console.WriteLine(st.StudentNum);

        }
    }
}
