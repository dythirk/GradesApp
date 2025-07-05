using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApp
{
    public class Student
    {
        string Name;
        int ID;
        List<double> Grades = new List<double>();

        public void AddGrade(double Grade)
        {
            Grades.Add(Grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
    }
}
