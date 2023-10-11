using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class Course
    {
        // Fields
        public string CourseName { get; set; }
        public string CourseGrade { get; set; }
        public int CoursePercentage { get; set; }
        public int StudentID { get; set; }

        // Constructors
        // I need to specify what I want the grade to be if the value is NULL
        public Course()
        {

        }
        public Course(string courseName, string courseGrade)
        {
            this.CourseName = courseName;
            this.CourseGrade = courseGrade;
        }
        public Course(string courseName, string courseGrade, int stuID)
        {
            this.CourseName = courseName;
            this.CourseGrade = courseGrade;
            this.StudentID = stuID;
        }
        public Course(string courseName, string courseGrade, int coursePercentage, int stuID)
        {
            this.CourseName = courseName;
            this.CourseGrade = courseGrade;
            this.CoursePercentage = coursePercentage;
            this.StudentID = stuID;
        }
    }
}
