using System;

namespace Shared.EntitiesForProj
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int QuestionRevisionNo { get; set; }
        public int EvalPeriodsTypesID { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionText { get; set; }
        public int DepID { get; set; }
        public int AnswerTypeId { get; set; }
        public bool IsLatestRevision { get; set; }
        public bool IsObsoleteQuestion { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Cloak { get; set; }

        public EvalPeriodType EvalPeriodType { get; set; }
        public AnswerType AnswerType { get; set; }
    }
}
