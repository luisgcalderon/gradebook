using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Luis' Grade Book");
            // Loop
            book.AddGrades();

            Statistics stats = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            Console.WriteLine($"The are {stats.Count} grades in the book.");

        }
    }
}
