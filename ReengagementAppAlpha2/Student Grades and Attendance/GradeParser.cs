using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class GradeParser
    {
        public List<Gradebook> ParseCourses(string csvFile)
        {
            List<Gradebook> allGradebooks = new List<Gradebook>();

            // Read the CSV file
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
                    string courseDesc = cells[5];
                    string courseGrade = cells[6];
                    //string courseStartTerm = cells[7];

                    // Create a new course from what if found on the line being read on the CSV
                    Course newCourse = new Course { CourseName = courseDesc, CourseGrade = courseGrade };

                    bool gradebookExists = false;

                    for (int i = 0; i < allGradebooks.Count; i++)
                    {
                        // If a gradebook already exists for a student, add the current course to it
                        if (allGradebooks[i].StudentID == studentID)
                        {
                            gradebookExists = true;
                            allGradebooks[i].StudentGradebook.Add(newCourse);
                            break;
                        }
                    }

                    // If a student doesn't have a gradebook yet, create a gradeboook, add the course to it, and add it to the list of all gradebooks
                    if (!gradebookExists)
                    {
                        Gradebook newGradebook = new Gradebook(studentID);
                        newGradebook.StudentGradebook.Add(newCourse);
                        allGradebooks.Add(newGradebook);
                    }
                }

                return allGradebooks;
            }
        }
    }
}
