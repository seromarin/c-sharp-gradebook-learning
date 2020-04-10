using System;

namespace GradleBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Seromarin Grade Book");

            book.AddGrade(89.3);
            book.AddGrade(345.3);
            book.AddGrade(34.3);
            book.AddGrade(56.3);

            book.AverangeGrade();
            Console.WriteLine($"Using {book.name}");

        }
    }
}
