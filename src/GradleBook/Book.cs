using System;
using System.Collections.Generic;
using System.Linq;

namespace GradleBook
{
    class Book
    {
        List<double> grades;
        public string name { get; }

        public Book(string name)
        {
            this.name = name;
            grades = new List<double> {};
        }

        internal void AddGrade(double grade) => grades.Add(grade);

        internal double AverangeGrade() => grades.Aggregate((acc, x) => acc + x);
    }
}
