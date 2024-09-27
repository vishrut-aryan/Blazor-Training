using Data.Enums;
using System.ComponentModel;

namespace Shared.EntitiesForProj
{
    public class Question
    {
        public int Id { get; set; }
        public int QRev { get; set; }
        [DisplayName("#")]
        public int QNum { get; set; }
        public QuestionType QType { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        [DisplayName("Question Heading")]
        public string QuestionHeader { get; set; }

        [DisplayName("Question Text")]
        public string QuestionText { get; set; }

        [DisplayName("Rating Guidance")]
        public string RatingGuidance { get; set; }

        public bool IsLatestRevision { get; set; }

        public bool IsObsoleteQuestion { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public bool Cloak { get; set; }
    }
}