using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Luis' Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            Statistics result = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {result.Low:N1}");
            Console.WriteLine($"The highest grade is {result.High:N1}");
            Console.WriteLine($"The average grade is {result.Average:N1}");
            
        }
    }
}
