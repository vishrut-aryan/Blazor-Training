using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.EntitiesForProj
{
    public class Employee
    {
        public int Id { get; set; }
        public string ADPAssociateId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SupervisorId { get; set; }
        public string ADPSupervisorId { get; set; }
        public string ADPSiteLocation { get; set; }
        public string ADPDepartment { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public DateTime? HireDate { get; set; }
        public bool IsEmployeeExempted { get; set; }
        public bool InactiveEmployee { get; set; }

        public int? ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }
    }
}
