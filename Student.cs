using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    /// <summary>
    /// Represents a student with a name and a collection of grades.
    /// </summary>
    internal class Student
    {
        private string _name;
        private int[] _grades;


        /// <summary>
        /// Gets or sets the student's name.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }


        /// <summary>
        /// Gets or sets the list of student's grades.
        /// </summary>
        public int[] Grades 
        {
            get => _grades;
            set => _grades = value;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with default values.
        /// Default name is "Ivan" and default grades are [5, 5, 5].
        /// </summary>
        public Student()
        {
            Name = "Ivan";
            Grades = new int[] {5, 5, 5};
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with the specified name and grades.
        /// </summary>
        /// <param name="name">The student's name.</param>
        /// <param name="grades">An array of grades for the student.</param>
        public Student(string name, params int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class by copying grades from another student.
        /// </summary>
        /// <param name="name">The student's name.</param>
        /// <param name="other">The student from which to copy grades.</param>
        public Student(string name, Student other)
        {
            Name = name;
            Grades = (int[])other.Grades.Clone();
        }


        /// <summary>
        /// Returns a string representation of the student in the format "Name: [grade1, grade2, ...]".
        /// </summary>
        /// <returns>A string representation of the student.</returns>
        public override string ToString()
        {
            return $"{Name}: [{string.Join(", ", Grades)}]";
        }
    }
}
