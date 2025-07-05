using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Student
    {
        public string Name;
        public int ID;
        public List<double> Grades = new List<double>();

        public void AddGrade(double Grade)  //Adding a single grade
        {
            Grades.Add(Grade);
        }

        public void AddGrade(params double[] grades)    // Adding an array (overloading the AddGrade)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)  // Testing for a null list
            {
                return 0;
            }
            else
            {
                return Grades.Average();
            }
        }

        public Student( string name,  int id)   // Constructor for two default fields
        {
            Name = name;
            ID = id;
        }
    }

