using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApp
{
    public class Student
    {
        public string Name;
        public int ID;
        public List<double> Grades = new List<double>();

        public void AddGrade(double Grade)
        {
            Grades.Add(Grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            else
            {
                return Grades.Average();
            }
        }

        public Student( string name,  int id)
        {
            Name = name;
            ID = id;
        }
    }
}
