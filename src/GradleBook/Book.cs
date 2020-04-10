using System;
using System.Collections.Generic;
using System.Linq;

namespace GradleBook
{
    class Book
    {
        List<double> grades;
        public Book()
        {
            grades = new List<double> {};
        }

        internal void AddGrade(double grade) => grades.Add(grade);

        internal double AverangeGrade() => grades.Aggregate((acc, x) => acc + x);
    }
}
