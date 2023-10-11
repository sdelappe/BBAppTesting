using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class Gradebook
    {
        // Fields
        public int StudentID { get; set; }
        public List<Course> StudentGradebook { get; set; }

        // Constructors
        public Gradebook()
        {

        }

        public Gradebook(int studentID)
        {
            this.StudentID = studentID;
            StudentGradebook = new List<Course>();
        }

        public Gradebook(List<Course> gradebook)
        {
            this.StudentGradebook = gradebook;
        }

        public Gradebook(int studentID, List<Course> gradebook)
        {
            this.StudentID = studentID;
            this.StudentGradebook = gradebook;
        }
    }
}
