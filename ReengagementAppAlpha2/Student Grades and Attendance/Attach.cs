using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class Attach
    {
        public void AttachGradebooks(List<Student> allStudents, List<Gradebook> allGradebooks)
        {
            for (int i = 0; i < allStudents.Count; i++)
            {
                for (int j = 0; j < allGradebooks.Count; j++)
                {
                    if (allStudents[i].StudentID == allGradebooks[j].StudentID)
                    {
                        allStudents[i].Gradebook = allGradebooks[j];
                    }
                }
            }
        }

        public void AttachAttendanceLogs(List<Student> allStudents, List<AttendanceLog> allAttLogs)
        {
            for (int i = 0; i < allStudents.Count; i++)
            {
                for (int j = 0; j < allAttLogs.Count; j++)
                {
                    if (allStudents[i].StudentID == allAttLogs[j].StudentID)
                    {
                        allStudents[i].AttendanceLog = allAttLogs[j];
                    }
                }
            }
        }
    }
}
