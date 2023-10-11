using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class AttDate
    {
        public DateTime AttendanceDate { get; set; }
        public int NumAbsences { get; set; }
        public int NumTardies { get; set; }
        public int NumExcused { get; set; }
        public int NumUnexcused { get; set; }
        public int StudentID { get; set; }

        // Constructors
        public AttDate()
        {
            NumAbsences = 0;
            NumTardies = 0;
            NumExcused = 0;
            NumUnexcused = 0;
        }
        public AttDate(DateTime date)
        {
            this.AttendanceDate = date;
            NumAbsences = 0;
            NumTardies = 0;
            NumExcused = 0;
            NumUnexcused = 0;
        }
    }
}
