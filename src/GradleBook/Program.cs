using System;
using System.Collections.Generic;

namespace GradleBook
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> grades = new List<double>() { 123.34, 234.234, 235235.235, 234.234 };

            grades.Add(1.34);

            foreach (double grade in grades)
            {
                Console.WriteLine($"The result is equal to {grade:N2}");
            }



        }
    }
}
