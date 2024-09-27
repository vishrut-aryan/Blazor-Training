namespace Shared.EntitiesForProj
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
        public virtual List<ScheduleYear> ScheduleYears { get; set; } = new List<ScheduleYear>();
    }
}