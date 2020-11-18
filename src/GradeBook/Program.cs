using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new[] {12.7, 10.3, 6.11, 4.1};

            double res = 0.0;

            foreach(double number in numbers)
            {
                res += number;
            }

            System.Console.WriteLine(res);
            
            Console.WriteLine("Hello World!");
        }
    }
}
