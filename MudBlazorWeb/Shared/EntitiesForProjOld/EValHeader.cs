using Data.Enums;
using Shared.TestItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.EntitiesForProj
{
    public class EValHeader
    {
        public int Id { get; set; }

        [DisplayName("Employee")]
        [StringLength(30)]
        public string UserId { get; set; }

        [DisplayName("Supervisor")]
        [StringLength(30)]
        public string SupervisorId { get; set; }

        [DisplayName("Division Head")]
        [StringLength(30)]
        public string DivHeadId { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Submission Date")]
        public DateTime? SubmissionDate { get; set; }

        [DisplayName("Issuance Date")]
        public DateTime? SupervisorSubmissionDate { get; set; }

        public StatusTypes Status { get; set; }

        public bool IsLeader { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(30)]
        public string EmployeeSign { get; set; }
        public DateTime? EmployeeSignDate { get; set; }
        public string OverallComment { get; set; }

        [StringLength(30)]
        public string SupervisorSign { get; set; }
        public DateTime? SupervisorSignDate { get; set; }
        public string OverallSupervisorComment { get; set; }

        [StringLength(30)]
        public string ExecSign { get; set; }
        public DateTime? ExecSignDate { get; set; }
        public string OverallExecComment { get; set; }

        public int Year { get; set; }
        public PeriodType RecordType { get; set; }
        public bool IsAnniversary { get; set; }

        public double? AssociateGlobalRatingAverage { get; set; }
        public double? SupervisorGlobalRatingAverage { get; set; }

        public int? ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }

        public List<EValResponse> Responses { get; set; }

        public List<Attendance> Attendances { get; set; }

    }
}
