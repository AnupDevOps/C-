using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name=name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            
        }
        
        public void ShowStatics()
        {
            // var grades = new List<double>(){23.3, 23.4, 23.3, 7.0};
            // grades.Add(55.2);
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            var grades_count = grades.Count;

            Console.WriteLine("Sum is "+ result);
            var ave = result/grades_count;
            System.Console.WriteLine($"Lowest Grade {lowGrade}");
            System.Console.WriteLine($"Highest Grade {highGrade}");
            System.Console.WriteLine($"Average of grades { ave:N1}");
        }
        private List<double> grades;
        private string name;
    }

}