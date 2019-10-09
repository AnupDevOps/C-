using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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
        
        public Statistics GetStatics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            // var grades = new List<double>(){23.3, 23.4, 23.3, 7.0};
            // grades.Add(55.2);
            // var result = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            //var grades_count = grades.Count;

            //Console.WriteLine("Sum is "+ result);
            result.Average = result.Average/grades.Count;
            return result;
            
        }
        private List<double> grades;
        private string name;
    }

}