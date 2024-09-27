using System;

namespace Shared.EntitiesForProj
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int ADPAssociateId { get; set; }
        public int Absences { get; set; }
        public int LateArrival { get; set; }
        public int EarlyLeaves { get; set; }
        public int ScheduledDaysOff { get; set; }
        public float AttendanceScore { get; set; }
    }
}
