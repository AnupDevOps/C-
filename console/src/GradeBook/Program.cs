using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Anup Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.GetStatics();
           
            var stats = book.GetStatics();
            System.Console.WriteLine($"Lowest Grade {stats.Low}");
            System.Console.WriteLine($"Highest Grade {stats.High}");
            System.Console.WriteLine($"Average of grades { stats.Average:N1}");

            // var x = 35.5;
            // var y = 55.5;
            // var z = x + y;
            // Console.WriteLine("Welcome to C#");

            //double[] numbers = new double[3];
            //numbers[0] = 23.3;
            //numbers[1] = 22.3;
            //numbers[2] = 23.3;
             // Another way of array intalization:
            //double[] numbers = new double[3]{23.3, 23.4, 23.3};

            // best way 
            //var numbers = new []{23.3, 23.4, 23.3, 7.0};
            //List<double> grades = new List<double>();
            // best way 
            
        }
    }
}
