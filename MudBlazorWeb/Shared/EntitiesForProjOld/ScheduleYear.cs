namespace Shared.EntitiesForProj
{
    public class ScheduleYear
    {
        public int Id { get; set; }
        public int Year { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public List<Period> Periods { get; set; } = new List<Period>();
    }
}