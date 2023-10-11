using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class StudentParser
    {
        public List<Student> ParseStudents(string csvFile)
        {
            List<Student> allStudents = new List<Student>();

            using (StreamReader sr = new StreamReader(csvFile))
            {
                string line;
                bool firstLine = true; // Skip the header row
                while ((line = sr.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }

                    int grade;
                    int age;
                    int studentID;
                    string[] cells = line.Split(',');
                    string firstName = cells[0];
                    string lastName = cells[1];
                    Int32.TryParse(cells[2], out grade);
                    Int32.TryParse(cells[3], out age);
                    Int32.TryParse(cells[4], out studentID);

                    bool studentExists = false;

                    for (int i = 0; i < allStudents.Count; i++)
                    {
                        // Check to see if the student already exists
                        if (allStudents[i].StudentID == studentID)
                        {
                            studentExists = true;
                            break;
                        }
                    }

                    if (!studentExists)
                    {
                        // If the student is unique, create a new student object
                        Student student = new Student { FirstName = firstName, LastName = lastName, Grade = grade, Age = age, StudentID = studentID };
                        allStudents.Add(student);
                    }
                }

                return allStudents;
            }
        }
    }
}
