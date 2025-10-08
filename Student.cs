using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    internal class Student
    {
        private string _name;
        private List<int> _grades;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<int> Grades 
        { 
            get { return _grades; }
            set { _grades = value; }
        }

        public Student()
        {
            Name = "Ivan";
            Grades = new List<int>(){5, 5, 5};
        }

        public Student(string name, params int[] grades)
        {
            Name = name;
            Grades = new List<int>(grades);
        }

        public Student(string name, Student other)
        {
            Name = name;
            Grades = new List<int>(other.Grades);
        }


        public override string ToString()
        {
            string allGrades = "";
            for (int i = 0; i < Grades.Count; i++)
            {
                allGrades += Grades[i].ToString();
                if (i < Grades.Count - 1)
                {
                    allGrades += ", ";
                }
            }
            return $"{Name}: [{allGrades}]";
        }
    }
}
