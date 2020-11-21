using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        public void ShowStatistics()
        {
            double res = 0.0;
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            foreach(double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                res += number;
            }

            res /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The average grade is {res:N1}");
        }
        private List<double> grades;
        private string name;

    }
}