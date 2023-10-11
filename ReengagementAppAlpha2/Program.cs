using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class Program
    {
        const string csvPath1 = "Two Student Grades.csv";
        const string csvPath2 = "Two Student Attendance.csv";

        static void Main(string[] args)
        {
            var getStudents = new StudentParser();
            var getGrades = new GradeParser();
            var getAttendance = new AttendanceParser();
            var attacher = new Attach();

            // Getting a list of students
            var uniqueStudents = getStudents.ParseStudents(csvPath1);

            // Generating a list of gradebooks for each student
            var gradeTest = getGrades.ParseCourses(csvPath1);

            // Generating a list of attendance logs for each student
            var attLogTest = getAttendance.ParseAbsences(csvPath2);

            // Attaching gradebooks to their correct students
            attacher.AttachGradebooks(uniqueStudents, gradeTest);

            // Attaching attendance logs to their correct students
            attacher.AttachAttendanceLogs(uniqueStudents, attLogTest);

            // DO NOT DELETE CODE BELOW

            // PRINTING THE RESULTS OF ALL STUDENT GRADES, SHOWING THE STUDENT PARSER AND GRADE PARSER ARE WORKING
            //foreach (var stu in uniqueStudents)
            //{
            //    var grdbk = stu.Gradebook;
            //    Console.WriteLine(stu.FirstName + " " + stu.LastName);
            //    foreach (var item in grdbk.StudentGradebook)
            //    {
            //        Console.WriteLine(item.CourseName + " " + item.CourseGrade);
            //    }
            //    Console.WriteLine("-------------------------------------------");
            //}

            // PRINTING THE RESULTS OF ABSENCES ON A SPECIFIC DATE FOR EACH STUDENT, SHOWING THE ATTENDANCE PARSER IS WORKING
            //var attendanceTest = getAttendance.ParseAbsences(csvPath2);

            //foreach (var item in attendanceTest)
            //{
            //    Console.WriteLine(item.StudentID + "   : Number of absences = " + item.AttendanceDates[2].NumAbsences + ", Date: " + item.AttendanceDates[2].AttendanceDate);
            //}

            SpreadSheetConnector.ConnectToGoogle();

            SpreadSheetActions testUpload = new SpreadSheetActions();
            testUpload.GoogleUploadTest();

            //int rowId = 2;
            //string SHEET_NAME = "test";
            //string spreadsheetId = SpreadSheetConnector.spreadSheetId;
            //string range = $"{SHEET_NAME}!A{rowId}:V{rowId}";
            //var values = new Item
            //{
            //    WeekDay = "Monday",
            //    Date = "Today",
            //    Period0Grade = "",
            //    Period1Grade = "",
            //    Period2Grade = "",
            //    Period3Grade = "",
            //    Period4Grade = "",
            //    Period5Grade = "",
            //    Period6Grade = "",
            //    Period7Grade = "",
            //    Period8Grade = "",
            //    Period9Grade = "",
            //    Period0Attendance = "",
            //    Period1Attendance = "",
            //    Period2Attendance = "",
            //    Period3Attendance = "",
            //    Period4Attendance = "",
            //    Period5Attendance = "",
            //    Period6Attendance = "",
            //    Period7Attendance = "",
            //    Period8Attendance = "",
            //    Period9Attendance = ""
            //};
            //var valueRange = new ValueRange
            //{
            //    Values = ItemsMapper.MapToRangeData(values)
            //};

            //var appendRequest = SpreadSheetConnector.Service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
            //appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            //var appendResponse = appendRequest.Execute();

            Console.ReadLine();
        }
    }
}
