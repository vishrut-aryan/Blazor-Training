using System;

namespace Shared.EntitiesForProj
{
    public class UserProfile
    {
        public int UserProfileID { get; set; }
        public int ADPAssociateId { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int SupervisorID { get; set; }
        public int ADPSupervisorId { get; set; }
        public string ADPSiteLocation { get; set; }
        public string ADPDepartment { get; set; }
        public int DepID { get; set; }
        public DateTime? HireDate { get; set; }
        public bool IsExempted { get; set; }
        public bool IsInactive { get; set; }

        public UserProfile Supervisor { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
    }
}
