using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    internal class Student
    {
        public string StudentNo { get; set; } //Automatic property
        public string Name { get; set; }
        public string Surname { get; set; }
       
        private int numOfModules;

		public int NumOfModules
		{
			get { return numOfModules; }
			set {
                if (value < 2)
                {
                    throw new Exception($"Number of modules should be" +
                        $" 2 more. Current value is :{numOfModules}");
                }
                numOfModules = value; }
		}
        public string[] Modules { get; set; }

    public Student()
        {
            this.StudentNo = "ST0000";
            this.Name = "No Name";
            this.Surname = "Unknown";
            this.NumOfModules = 0;
            this.Modules = new string[NumOfModules];
        }

        public Student(string stNo, string theName, string theSurname, int numModules)
        {
            this.StudentNo = stNo;
            this.Name = theName;
            this.Surname = theSurname;
            this.NumOfModules = numModules;
            this.Modules = new string[NumOfModules];
        }

        public string Display()
        {
            string output = $"Student No: {StudentNo}\n" +
                $"Name: {Name} {Surname}\n" +
                $"Number of Modules: {NumOfModules}\n" +
                $"Modules:\n-----------------\n";

            foreach (string m in Modules)
            {
                output += $"{m}\n";
            }

            return output;
        }

    }
}
