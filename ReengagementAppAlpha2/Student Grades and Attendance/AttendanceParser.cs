using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class AttendanceParser
    {


        public List<AttendanceLog> ParseAbsences(string csvFile)
        {
            List<AttendanceLog> allAttendanceLogs = new List<AttendanceLog>();

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
                    int attYear;
                    DateTime attDate;
                    string[] cells = line.Split(',');
                    string firstName = cells[0];
                    string lastName = cells[1];
                    Int32.TryParse(cells[2], out grade);
                    Int32.TryParse(cells[3], out age);
                    Int32.TryParse(cells[4], out studentID);
                    Int32.TryParse(cells[5], out attYear);
                    DateTime.TryParse(cells[6], out attDate);
                    string weekDay = cells[7];
                    string period0 = cells[8];
                    string period1 = cells[9];
                    string period2 = cells[10];
                    string period3 = cells[11];
                    string period4 = cells[12];
                    string period5 = cells[13];
                    string period6 = cells[14];
                    string period7 = cells[15];
                    string period8 = cells[16];
                    string period9 = cells[17];

                    int absences = 0;
                    int tardies = 0;
                    int excusedAbs = 0;
                    int unexcusedAbs = 0;

                    // All of these should be made into loops
                    // Checking for tardies
                    if (period0.StartsWith("K") || period0.StartsWith("L") || period0.StartsWith("T") || period0.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period1.StartsWith("K") || period1.StartsWith("L") || period1.StartsWith("T") || period1.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period2.StartsWith("K") || period2.StartsWith("L") || period2.StartsWith("T") || period2.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period3.StartsWith("K") || period3.StartsWith("L") || period3.StartsWith("T") || period3.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period4.StartsWith("K") || period4.StartsWith("L") || period4.StartsWith("T") || period4.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period5.StartsWith("K") || period5.StartsWith("L") || period5.StartsWith("T") || period5.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period6.StartsWith("K") || period6.StartsWith("L") || period6.StartsWith("T") || period6.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period7.StartsWith("K") || period7.StartsWith("L") || period7.StartsWith("T") || period7.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period8.StartsWith("K") || period8.StartsWith("L") || period8.StartsWith("T") || period8.EndsWith("K"))
                    {
                        tardies++;
                    }
                    if (period9.StartsWith("K") || period9.StartsWith("L") || period9.StartsWith("T") || period9.EndsWith("K"))
                    {
                        tardies++;
                    }

                    //Checking for excused absences
                    if ((period0.StartsWith("1") || period0.StartsWith("3") || period0.StartsWith("E") || period0.StartsWith("Q") || period0.StartsWith("O")) && (!period0.EndsWith("K") && !period0.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period1.StartsWith("1") || period1.StartsWith("3") || period1.StartsWith("E") || period1.StartsWith("Q") || period1.StartsWith("O")) && (!period1.EndsWith("K") && !period1.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period2.StartsWith("1") || period2.StartsWith("3") || period2.StartsWith("E") || period2.StartsWith("Q") || period2.StartsWith("O")) && (!period2.EndsWith("K") && !period2.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period3.StartsWith("1") || period3.StartsWith("3") || period3.StartsWith("E") || period3.StartsWith("Q") || period3.StartsWith("O")) && (!period3.EndsWith("K") && !period3.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period4.StartsWith("1") || period4.StartsWith("3") || period4.StartsWith("E") || period4.StartsWith("Q") || period4.StartsWith("O")) && (!period4.EndsWith("K") && !period4.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period5.StartsWith("1") || period5.StartsWith("3") || period5.StartsWith("E") || period5.StartsWith("Q") || period5.StartsWith("O")) && (!period5.EndsWith("K") && !period5.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period6.StartsWith("1") || period6.StartsWith("3") || period6.StartsWith("E") || period6.StartsWith("Q") || period6.StartsWith("O")) && (!period6.EndsWith("K") && !period6.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period7.StartsWith("1") || period7.StartsWith("3") || period7.StartsWith("E") || period7.StartsWith("Q") || period7.StartsWith("O")) && (!period7.EndsWith("K") && !period7.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period8.StartsWith("1") || period8.StartsWith("3") || period8.StartsWith("E") || period8.StartsWith("Q") || period8.StartsWith("O")) && (!period8.EndsWith("K") && !period8.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }
                    if ((period9.StartsWith("1") || period9.StartsWith("3") || period9.StartsWith("E") || period9.StartsWith("Q") || period9.StartsWith("O")) && (!period9.EndsWith("K") && !period9.EndsWith("L")))
                    {
                        absences++;
                        excusedAbs++;
                    }

                    // Checking for unexcused absences
                    if ((period0.StartsWith("2") || period0.StartsWith("U") || period0.StartsWith("W")) && (!period0.EndsWith("K") && !period0.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period1.StartsWith("2") || period1.StartsWith("U") || period1.StartsWith("W")) && (!period1.EndsWith("K") && !period1.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period2.StartsWith("2") || period2.StartsWith("U") || period2.StartsWith("W")) && (!period2.EndsWith("K") && !period2.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period3.StartsWith("2") || period3.StartsWith("U") || period3.StartsWith("W")) && (!period3.EndsWith("K") && !period3.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period4.StartsWith("2") || period4.StartsWith("U") || period4.StartsWith("W")) && (!period4.EndsWith("K") && !period4.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period5.StartsWith("2") || period5.StartsWith("U") || period5.StartsWith("W")) && (!period5.EndsWith("K") && !period5.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period6.StartsWith("2") || period6.StartsWith("U") || period6.StartsWith("W")) && (!period6.EndsWith("K") && !period6.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period7.StartsWith("2") || period7.StartsWith("U") || period7.StartsWith("W")) && (!period7.EndsWith("K") && !period7.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period8.StartsWith("2") || period8.StartsWith("U") || period8.StartsWith("W")) && (!period8.EndsWith("K") && !period8.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }
                    if ((period9.StartsWith("2") || period9.StartsWith("U") || period9.StartsWith("W")) && (!period9.EndsWith("K") && !period9.EndsWith("L")))
                    {
                        absences++;
                        unexcusedAbs++;
                    }


                    bool attendanceLogExists = false;

                    for (int i = 0; i < allAttendanceLogs.Count; i++)
                    {
                        // If the student ID of the currently looked at attendance log matches the student ID in the csv file
                        if (allAttendanceLogs[i].StudentID == studentID)
                        {
                            attendanceLogExists = true;

                            for (int j = 0; j < allAttendanceLogs[i].AttendanceDates.Count; j++)
                            {
                                if (attDate == allAttendanceLogs[i].AttendanceDates[j].AttendanceDate)
                                {
                                    allAttendanceLogs[i].AttendanceDates[j].NumAbsences = absences;
                                    allAttendanceLogs[i].AttendanceDates[j].NumTardies = tardies;
                                    allAttendanceLogs[i].AttendanceDates[j].NumExcused = excusedAbs;
                                    allAttendanceLogs[i].AttendanceDates[j].NumUnexcused = unexcusedAbs;
                                }
                            }

                            break;
                        }
                    }

                    // If a student doesn't have a gradebook yet, create a gradeboook, add the course to it, and add it to the list of all gradebooks
                    if (!attendanceLogExists)
                    {
                        AttendanceLog newAttLog = new AttendanceLog(studentID); // creates a new attendance log for a student, has all dates of school year in it already
                        for (int i = 0; i < newAttLog.AttendanceDates.Count(); i++)
                        {
                            if (attDate == newAttLog.AttendanceDates[i].AttendanceDate)
                            {
                                newAttLog.AttendanceDates[i].NumAbsences = absences;
                                newAttLog.AttendanceDates[i].NumTardies = tardies;
                                newAttLog.AttendanceDates[i].NumExcused = excusedAbs;
                                newAttLog.AttendanceDates[i].NumUnexcused = unexcusedAbs;
                            }
                        }
                        allAttendanceLogs.Add(newAttLog);
                    }
                }

                return allAttendanceLogs;
            }
        }
    }
}
