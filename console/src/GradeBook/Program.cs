using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 35.5;
            var y = 55.5;
            var z = x + y;
            Console.WriteLine("Welcome to C#");

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
            var grades = new List<double>(){23.3, 23.4, 23.3, 7.0};
            grades.Add(55.2);


            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            var grades_count = grades.Count;

            Console.WriteLine("Sum is "+ result);
            var ave = result/grades_count;
            System.Console.WriteLine($"Average of grades { ave:N1}");


            if(args.Length >0)
            {
                Console.WriteLine("Hello "+ args[0] + "!");
                // another way to print 
                Console.WriteLine($"Hello, {args[1]}! ");
            }
            else
            {
                Console.WriteLine("Hello !");

            }
            
        }
    }
}
