﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new[] {12.7, 10.3, 6.11, 4.1};
            List<double> grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            double res = 0.0;
            foreach(double number in grades)
            {
                res += number;
            }

            System.Console.WriteLine(res);
            System.Console.WriteLine(res/grades.Capacity);
            
            Console.WriteLine("Hello World!");
        }
    }
}
