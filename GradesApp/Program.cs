// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace GradesApp;
{    
    class Program
    {
        public static void Main(string[] args)
        {
        List<Student> students = new List<Student>();

        var s1 = new Student("J Lennon", 1);
        var s2 = new Student("P McCartney", 2);
        var s3 = new Student("G Harrison", 3);
        var s4 = new Student("R Starr", 4);

        students.Add(s1);
        students.Add(s2);
        students.Add(s3);
        students.Add(s4);


        s1.AddGrade(94.3);
        s1.AddGrade(90.0, 78.9, 95.4);

        s2.AddGrade(95.4, 92.3);
        s2.AddGrade(91.5, 94.5);

        s3.AddGrade(98.4, 97.5, 96.6);
        s3.AddGrade(100);

        s4.AddGrade(80.1, 78.5, 79.1, 80.9);
        s4.AddGrade(79.9, 79.4);

        foreach (var student in students) 
        
        {
            Console.WriteLine($"Name: {student.Name} ID: {student.ID}");

            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"Grade: {grade}");
            }

            Console.WriteLine($"Grade Point Average: {student.CalculateAverageGrade()}");
        
        }


    }

}






