using LINQtoCSV;
using System;
using System.Collections.Generic;

namespace ReengagementAppAlpha2
{
    [Serializable]

    internal class Student
    {
        // Fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public int StudentID { get; set; }
        public Gradebook Gradebook { get; set; }
        public AttendanceLog AttendanceLog { get; set; }

        // Constructors
        public Student()
        {

        }

        public Student(string firstName, string lastName, int grade, int age, int stuID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Age = age;
            this.StudentID = stuID;
        }

        public Student(string firstName, string lastName, int grade, int age, int stuID, Gradebook gradebook)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Age = age;
            this.StudentID = stuID;
            this.Gradebook = gradebook;
        }
    }
}
