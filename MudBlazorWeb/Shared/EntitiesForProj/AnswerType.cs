using System;

namespace Shared.EntitiesForProj
{
    public class AnswerType
    {
        public int AnswerTypeId { get; set; }
        public string AnswerTypeName { get; set; }

        public List<AnswerValue> AnswerValues { get; set; }
    }
}
