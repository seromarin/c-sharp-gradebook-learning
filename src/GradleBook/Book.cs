using System;
using System.Collections.Generic;
using System.Linq;

namespace GradleBook
{
    public class Book
    {
        List<double> grades;
        public string name { get; }

        public Book(string name)
        {
            this.name = name;
            grades = new List<double> {};
        }

        public void AddGrade(double grade) => grades.Add(grade);

        public double AverangeGrade() => Math.Round(grades.Aggregate((acc, x) => acc + x) / grades.Count, 2);

        public double highGrade() => grades.Aggregate((acc, x) => x > acc ? x : acc);

        public object lowGrade() => grades.Aggregate((acc, x) => x < acc ? x : acc);
    }
}
