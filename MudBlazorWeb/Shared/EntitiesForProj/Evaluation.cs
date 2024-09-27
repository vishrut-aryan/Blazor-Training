using System;

namespace Shared.EntitiesForProj
{
    public class Evaluation
    {
        public int EvaluationID { get; set; }
        public int EvalPeriodTypeID { get; set; }
        public int UserProfileID { get; set; }
        public int EvalResponseID { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string? EmployeeOverallComment { get; set; }
        public string? SupervisorOverallComment { get; set; }
        public DateTime? SupervisorCommentDate { get; set; }
        public DateTime? EmployeeCommentDate { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public string EmployeeSign { get; set; }
        public string SupervisorSign { get; set; }
        public DateTime? EmployeeSignDate { get; set; }
        public DateTime? SupervisorSignDate { get; set; }
        public int AttendanceID { get; set; }
        public float AggregateEvalScore { get; set; }
        public bool IsPass { get; set; }

        public EvalPeriodType EvalPeriodType { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<EvalResponse>? EvalResponses { get; set; }
        public Attendance Attendance { get; set; }
    }
}
