using System;

namespace Shared.EntitiesForProj
{
    public class EvalResponse
    {
        public int EvalResponseID { get; set; }
        public string SupervisorComment { get; set; }
        public int QuestionID { get; set; }
        public int AnswerValueId { get; set; }

        public Question Question { get; set; }
        public ICollection<AnswerValue> AnswerValues { get; set; }
    }
}
