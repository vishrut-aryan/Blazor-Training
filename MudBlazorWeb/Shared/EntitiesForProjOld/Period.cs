using Data.Enums;

namespace Shared.EntitiesForProj
{
    public class Period
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PeriodType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int? ScheduleYearId { get; set; }
        public ScheduleYear? ScheduleYear { get; set; }
    }
}