using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;

            }
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);

            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }
        public void AddGrades()
        {
            int index = 1;
            do
            {
                Console.WriteLine($"Add grade {index} or enter 'q' to quit:");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    try
                    {
                        double grade = double.Parse(input);
                        AddGrade(grade);
                        index++;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Add a valid grade");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Add a valid grade");
                    }
                }
            } while (true);
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(int index= 0;index<grades.Count;index++)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }

            result.Average /= grades.Count;
            switch(result.Average)
            {
                case double d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case double d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case double d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case double d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;


            }
            result.Count = grades.Count;
            return result;

        }
        private List<double> grades;
        public string Name;

    }
}