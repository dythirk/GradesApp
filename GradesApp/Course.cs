using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApp
{
    public class Course
    {
        public string CourseName;
        public string CourseCode;

        public List<Student> EnrolledStudents = new List<Student>();

        public Course(string courseName, string courseCode)
        {
            CourseName = courseName;
            CourseCode = courseCode;

            EnrolledStudents = new List<Student>();
        }

        public void EnrollStudents(Student student) 
        {
            if (!EnrolledStudents.Contains(student))
                {
                EnrolledStudents.Add(student);                
                }
        }

    }
}
