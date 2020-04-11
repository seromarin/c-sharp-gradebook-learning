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

        public double HighGrade() => grades.Aggregate((acc, x) => x > acc ? x : acc);

        public double LowGrade() => grades.Aggregate((acc, x) => x < acc ? x : acc);

        public Stadistics GetStadistics() {
            Stadistics stadistics = new Stadistics();

            stadistics.Averange = 0.0;
            stadistics.High = Double.MinValue;
            stadistics.Low = Double.MaxValue;

            foreach (double grade in grades)
            {   
                stadistics.High = Math.Max(grade, stadistics.High);
                stadistics.Low = Math.Min(grade, stadistics.Low);
                stadistics.Averange += grade;
            }

            stadistics.Averange = Math.Round(stadistics.Averange / grades.Count, 2);

            return stadistics;

        }
    }
}
